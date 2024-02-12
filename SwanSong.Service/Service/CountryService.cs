using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class CountryService : ICountryService
{ 
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper; 
    public readonly IValidatorHelper<Country> _validatorHelper;

    public CountryService(IMapper mapper,
                          IValidatorHelper<Country> validatorHelper,
                          IMemoryCache memoryCache,
                          IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<List<CountryResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<CountryResponse>>(CacheKeys.Country, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<CountryResponse>>(await _unitOfWork.Countries.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    } 

    public async Task<CountryActionResponse> AddAsync(CountryAddRequest countryAddRequest)
    {
        var country = _mapper.Map<Country>(countryAddRequest);
         
        await BeforeSaveAsync(country);
        await SaveAddAsync(country, CacheKeys.Country);

        return await AfterSaveAsync(country);
         
    }

    public async Task<CountryActionResponse> UpdateAsync(CountryUpdateRequest countryUpdateRequest)
    { 
        var country = await UpdateCountryAsync(countryUpdateRequest);

        await BeforeSaveAsync(country);
        await SaveUpdateAsync(country, CacheKeys.Country);

        return await AfterSaveAsync(country);  
    }

    public async Task<CountryActionResponse> DeleteAsync(int id)
    { 
        var country = await GetCountryAsync(id);
 
        await BeforeDeleteAsync(country);
        await DeleteAsync(country, CacheKeys.Country);

        return await AfterDeleteAsync(country); 
    }

    #endregion 

    #region Private Functions

    private async Task<Country> UpdateCountryAsync(CountryUpdateRequest countryUpdateRequest)
    {
        var country = await GetCountryAsync(countryUpdateRequest.Id);
        country.Name = countryUpdateRequest.Name;

        return country;
    }

    private async Task BeforeSaveAsync(Country country)
    {
        await _validatorHelper.ValidateAsync(country, Constants.ValidationEventBeforeSave);
    }

    private async Task<CountryActionResponse> AfterSaveAsync(Country country)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(country, Constants.ValidationEventAfterSave);
        return new CountryActionResponse(country.Id, country.Name, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(Country country)
    {
        await _validatorHelper.ValidateAsync(country, Constants.ValidationEventBeforeDelete);
    }

    private async Task<CountryActionResponse> AfterDeleteAsync(Country country)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(country, Constants.ValidationEventAfterDelete);
        return new CountryActionResponse(country.Id, country.Name, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    }

    private async Task DeleteAsync(Country country, string cacheKey)
    {
        _unitOfWork.Countries.Delete(country);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveAddAsync(Country country, string cacheKey)
    {
        await _unitOfWork.Countries.AddAsync(country);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(Country country, string cacheKey)
    {
        _unitOfWork.Countries.Update(country);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    } 

    private async Task<Country> GetCountryAsync(int id)
    {
        var country = await _unitOfWork.Countries.ByIdAsync(id);
        if (country == null)
        {
            throw new CountryNotFoundException("Country not found.");
        }

        return country;
    }

    #endregion
}