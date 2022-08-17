using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class CountryService : BaseService<Country, CountryDto>, ICountryService
    {
        public CountryService(IMapper mapper,
                              IValidator<Country> validator,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork,
                              IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<List<CountryReadOnlyDto>> GetAllAsync()
        {
            return await _memoryCache.GetOrCreateAsync<List<CountryReadOnlyDto>>(CacheKeys.Country, async cache =>
            {
                cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
                return _mapper.Map<List<CountryReadOnlyDto>>(await _unitOfWork.Countries.AllAsync()).OrderBy(c => c.Name).ToList();
            });
        }

        public async Task<CountryDto> GetAsync(int id)
        {
            return _mapper.Map<CountryDto>(await _unitOfWork.Countries.ByIdAsync(id));
        }

        public async Task<CountryDto> SaveAsync(CountryDto countryDto)
        {
            Country country = await GetCountryAsync(countryDto);

            ValidationResult result = await BeforeSaveAsync(country);
            if (!result.IsValid)
                return GetDto(GetEntity(country), result.Errors, false);

            country = await SaveAsync(country);

            return GetDto(country, await AfterSaveAsync(country, CacheKeys.Country), true);
        }

        public async Task<CountryDto> DeleteAsync(int id)
        {
            Country country = await _unitOfWork.Countries.ByIdAsync(id);

            ValidationResult result = await BeforeDeleteAsync(country);
            if (!result.IsValid)
                return GetDto(GetEntity(country), result.Errors, false);

            await DeleteAsync(country);

            return GetDto(country, await AfterDeleteAsync(country, CacheKeys.Country), true); 
        }

        private async Task<Country> GetCountryAsync(CountryDto countryDto)
        {
            Country currentCountry = countryDto.Id > 0 ? new() : await _unitOfWork.Countries.ByIdAsync(countryDto.Id);
            return _mapper.Map<CountryDto, Country>(countryDto, currentCountry);
        } 

        private async Task<Country> SaveAsync(Country country)
        {
            if (country.Id == 0)
                _unitOfWork.Countries.Add(country);
            else
                _unitOfWork.Countries.Update(country);

            await _unitOfWork.Complete();

            return country;
        }

        private async Task DeleteAsync(Country country)
        {
            _unitOfWork.Countries.Remove(country);
            await _unitOfWork.Complete();
        }
    }
}
