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
    public class BirthPlaceService : BaseService<BirthPlace, BirthPlaceDto>, IBirthPlaceService
    {
        public BirthPlaceService(IMapper mapper,
                                 IValidator<BirthPlace> validator,
                                 IMemoryCache memoryCache,
                                 IUnitOfWork unitOfWork,
                                 IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<List<BirthPlaceDto>> GetAllAsync()
        {
            return await _memoryCache.GetOrCreateAsync<List<BirthPlaceDto>>(CacheKeys.BirthPlace, async cache =>
            {
                cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30); 
                return _mapper.Map<List<BirthPlaceDto>>(await _unitOfWork.BirthPlaces.AllAsync()).OrderBy(b => b.Name).ToList();
            });            
        }

        public async Task<BirthPlaceDto> GetAsync(int id)
        {
            return _mapper.Map<BirthPlaceDto>(await _unitOfWork.BirthPlaces.ByIdAsync(id)); 
        }
         
        public async Task<BirthPlaceDto> SaveAsync(BirthPlaceDto birthPlaceDto)
        {
            BirthPlace birthPlace = await GetBirthPlaceAsync(birthPlaceDto); 

            ValidationResult result = BeforeSave(birthPlace);
            if (!result.IsValid)
                return GetDto(GetEntity(birthPlace), result.Errors, false);

            birthPlace = await SaveAsync(birthPlace);

            return GetDto(birthPlace, AfterSave(birthPlace, CacheKeys.BirthPlace), true);   
        }

        public async Task<BirthPlaceDto> DeleteAsync(int id)
        {
            BirthPlace birthPlace = await _unitOfWork.BirthPlaces.ByIdAsync(id); 

            ValidationResult result = BeforeDelete(birthPlace);
            if (!result.IsValid)
                return GetDto(GetEntity(birthPlace), result.Errors, false); 

            birthPlace = await Delete(birthPlace);

            return GetDto(birthPlace, AfterDelete(birthPlace, CacheKeys.BirthPlace), true); 
        } 

        private async Task<BirthPlace> GetBirthPlaceAsync(BirthPlaceDto birthPlaceDto)
        {
            BirthPlace currentBirthPlace = birthPlaceDto.Id > 0 ? new() : await _unitOfWork.BirthPlaces.ByIdAsync(birthPlaceDto.Id);
            return _mapper.Map<BirthPlaceDto, BirthPlace>(birthPlaceDto, currentBirthPlace);
        }

        private async Task<BirthPlace> SaveAsync(BirthPlace birthPlace)
        {
            if (birthPlace.Id == 0)
                _unitOfWork.BirthPlaces.Add(birthPlace);
            else
                _unitOfWork.BirthPlaces.Update(birthPlace);

            await _unitOfWork.Complete();

            return birthPlace;
        }

        private async Task<BirthPlace> Delete(BirthPlace birthPlace)
        {
            _unitOfWork.BirthPlaces.Remove(birthPlace);
            await _unitOfWork.Complete();

            return birthPlace;
        }
    }
}
