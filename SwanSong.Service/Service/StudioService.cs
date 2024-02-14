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

public class StudioService : IStudioService
{
    private readonly IMemoryCache _memoryCache;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IValidatorHelper<Studio> _validatorHelper;

    public StudioService(IMapper mapper,
                         IValidatorHelper<Studio> validatorHelper,
                         IMemoryCache memoryCache,
                         IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<List<StudioResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<StudioResponse>>(CacheKeys.Studio, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<StudioResponse>>(await _unitOfWork.Studios.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    } 

    public async Task<StudioActionResponse> AddAsync(StudioAddRequest studioAddRequest)
    {
        var studio = _mapper.Map<Studio>(studioAddRequest);

        await BeforeSaveAsync(studio);
        await SaveAddAsync(studio, CacheKeys.Studio);

        return await AfterSaveAsync(studio); 
    }

    public async Task<StudioActionResponse> UpdateAsync(StudioUpdateRequest studioUpdateRequest)
    {  
        var studio = await UpdateStudioAsync(studioUpdateRequest);

        await BeforeSaveAsync(studio);
        await SaveUpdateAsync(studio, CacheKeys.Studio);

        return await AfterSaveAsync(studio); 
    }

    public async Task<StudioActionResponse> DeleteAsync(int id)
    {
        var studio = await GetStudioAsync(id);

        await BeforeDeleteAsync(studio);
        await DeleteAsync(studio, CacheKeys.Studio);

        return await AfterDeleteAsync(studio);
    }

    #endregion

    #region Private Functions

    private async Task<Studio> UpdateStudioAsync(StudioUpdateRequest studioUpdateRequest)
    {
        var studio = await GetStudioAsync(studioUpdateRequest.Id);
        studio.Name = studioUpdateRequest.Name;

        return studio;
    }

    private async Task BeforeSaveAsync(Studio studio)
    {
        await _validatorHelper.ValidateAsync(studio, Constants.ValidationEventBeforeSave);
    }

    private async Task<StudioActionResponse> AfterSaveAsync(Studio studio)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(studio, Constants.ValidationEventAfterSave); 
        return new StudioActionResponse(studio.Id, studio.Name, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }    

    private async Task BeforeDeleteAsync(Studio studio)
    {
        await _validatorHelper.ValidateAsync(studio, Constants.ValidationEventBeforeDelete);
    }

    private async Task<StudioActionResponse> AfterDeleteAsync(Studio studio)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(studio, Constants.ValidationEventAfterDelete);
        return new StudioActionResponse(studio.Id, studio.Name, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    }

    private async Task SaveAddAsync(Studio studio, string cacheKey)
    {
        await _unitOfWork.Studios.AddAsync(studio);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork); 
    }

    private async Task SaveUpdateAsync(Studio studio, string cacheKey)
    {
        _unitOfWork.Studios.Update(studio);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork); 
    }

    private async Task DeleteAsync(Studio studio, string cacheKey)
    {
        _unitOfWork.Studios.Delete(studio);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork); 
    } 

    private async Task<Studio> GetStudioAsync(int id)
    {
        var studio = await _unitOfWork.Studios.ByIdAsync(id);
        if (studio == null)
        {
            throw new StudioNotFoundException("Studio not found.");
        }

        return studio;
    }

    #endregion

}