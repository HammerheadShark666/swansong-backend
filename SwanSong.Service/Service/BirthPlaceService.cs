using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
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

public class BirthPlaceService : IBirthPlaceService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<BirthPlace> _validatorHelper;

    public BirthPlaceService(IMapper mapper,
                             IValidatorHelper<BirthPlace> validatorHelper,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<List<BirthPlaceResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<BirthPlaceResponse>>(CacheKeys.BirthPlace, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<BirthPlaceResponse>>(await _unitOfWork.BirthPlaces.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    }

    public async Task<BirthPlaceActionResponse> AddAsync(BirthPlaceAddRequest birthPlaceAddRequest)
    {
        var birthPlace = _mapper.Map<BirthPlace>(birthPlaceAddRequest);

        await BeforeSaveAsync(birthPlace);
        await SaveAddAsync(birthPlace, CacheKeys.BirthPlace);

        return await AfterSaveAsync(birthPlace);
    }

    public async Task<BirthPlaceActionResponse> UpdateAsync(BirthPlaceUpdateRequest birthPlaceUpdateRequest)
    {
        var birthPlace = await UpdateBirthPlaceAsync(birthPlaceUpdateRequest);

        await BeforeSaveAsync(birthPlace);
        await SaveUpdateAsync(birthPlace, CacheKeys.Studio);

        return await AfterSaveAsync(birthPlace);        
    }

    public async Task<BirthPlaceActionResponse> DeleteAsync(int id)
    {
        var birthPlace = await GetBirthPlaceAsync(id);

        await BeforeDeleteAsync(birthPlace);
        await DeleteAsync(birthPlace, CacheKeys.BirthPlace);

        return await AfterDeleteAsync(birthPlace); 
    }

    #endregion

    #region Private Functions

    private async Task<BirthPlace> UpdateBirthPlaceAsync(BirthPlaceUpdateRequest birthPlaceUpdateRequest)
    {
        var birthPlace = await GetBirthPlaceAsync(birthPlaceUpdateRequest.Id);
        birthPlace.Name = birthPlaceUpdateRequest.Name;

        return birthPlace;
    }

    private async Task BeforeSaveAsync(BirthPlace birthPlace)
    {
        await _validatorHelper.ValidateAsync(birthPlace, Constants.ValidationEventBeforeSave);
    }

    private async Task<BirthPlaceActionResponse> AfterSaveAsync(BirthPlace birthPlace)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(birthPlace, Constants.ValidationEventAfterSave);
        return new BirthPlaceActionResponse(birthPlace.Id, birthPlace.Name, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(BirthPlace birthPlace)
    {
        await _validatorHelper.ValidateAsync(birthPlace, Constants.ValidationEventBeforeDelete);
    }

    private async Task<BirthPlaceActionResponse> AfterDeleteAsync(BirthPlace birthPlace)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(birthPlace, Constants.ValidationEventAfterDelete);
        return new BirthPlaceActionResponse(birthPlace.Id, birthPlace.Name, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    } 

    private async Task DeleteAsync(BirthPlace birthPlace, string cacheKey)
    {
        _unitOfWork.BirthPlaces.Delete(birthPlace);
        await DataHelper.CompleteContextActionAsync(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveAddAsync(BirthPlace birthPlace, string cacheKey)
    {
        await _unitOfWork.BirthPlaces.AddAsync(birthPlace);
        await DataHelper.CompleteContextActionAsync(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(BirthPlace birthPlace, string cacheKey)
    {
        _unitOfWork.BirthPlaces.Update(birthPlace);
        await DataHelper.CompleteContextActionAsync(cacheKey, _memoryCache, _unitOfWork);
    }
 
    private async Task<BirthPlace> GetBirthPlaceAsync(int id)
    {
        var birthPlace = await _unitOfWork.BirthPlaces.ByIdAsync(id);
        if (birthPlace == null)
        {
            throw new BirthPlaceNotFoundException("BirthPlace not found.");
        }

        return birthPlace;
    }

    #endregion

}