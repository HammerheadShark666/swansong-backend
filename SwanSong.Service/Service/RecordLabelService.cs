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

public class RecordLabelService : IRecordLabelService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<RecordLabel> _validatorHelper;

    public RecordLabelService(IMapper mapper,
                              IValidatorHelper<RecordLabel> validatorHelper,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<List<RecordLabelResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<RecordLabelResponse>>(CacheKeys.RecordLabel, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<RecordLabelResponse>>(await _unitOfWork.RecordLabels.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    } 

    public async Task<RecordLabelActionResponse> AddAsync(RecordLabelAddRequest recordLabelsAddRequest)
    {
        var recordLabel = _mapper.Map<RecordLabel>(recordLabelsAddRequest);
         
        await BeforeSaveAsync(recordLabel);
        await SaveAddAsync(recordLabel, CacheKeys.RecordLabel);

        return await AfterSaveAsync(recordLabel);
    }

    public async Task<RecordLabelActionResponse> UpdateAsync(RecordLabelUpdateRequest recordLabelUpdateRequest)
    {  
        var recordLabel = await UpdateRecordLabelAsync(recordLabelUpdateRequest);

        await BeforeSaveAsync(recordLabel);
        await SaveUpdateAsync(recordLabel, CacheKeys.RecordLabel);

        return await AfterSaveAsync(recordLabel); 
    }

    public async Task<RecordLabelActionResponse> DeleteAsync(int id)
    {
        var recordLabel = await GetRecordLabelAsync(id);

        await BeforeDeleteAsync(recordLabel);
        await DeleteAsync(recordLabel, CacheKeys.RecordLabel);

        return await AfterDeleteAsync(recordLabel); 
    }

    #endregion

    #region Private Functions

    private async Task<RecordLabel> UpdateRecordLabelAsync(RecordLabelUpdateRequest recordLabelUpdateRequest)
    {
        var recordLabel = await GetRecordLabelAsync(recordLabelUpdateRequest.Id);
        recordLabel.Name = recordLabelUpdateRequest.Name;

        return recordLabel;
    }

    private async Task BeforeSaveAsync(RecordLabel recordLabel)
    {
        await _validatorHelper.ValidateAsync(recordLabel, Constants.ValidationEventBeforeSave);
    }

    private async Task<RecordLabelActionResponse> AfterSaveAsync(RecordLabel recordLabel)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(recordLabel, Constants.ValidationEventAfterSave);
        return new RecordLabelActionResponse(recordLabel.Id, recordLabel.Name, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(RecordLabel recordLabel)
    {
        await _validatorHelper.ValidateAsync(recordLabel, Constants.ValidationEventBeforeDelete);
    }

    private async Task<RecordLabelActionResponse> AfterDeleteAsync(RecordLabel recordLabel)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(recordLabel, Constants.ValidationEventAfterDelete);
        return new RecordLabelActionResponse(recordLabel.Id, recordLabel.Name, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    } 

    private async Task SaveAddAsync(RecordLabel recordLabel, string cacheKey)
    {
        await _unitOfWork.RecordLabels.AddAsync(recordLabel);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(RecordLabel recordLabel, string cacheKey)
    {
        _unitOfWork.RecordLabels.Update(recordLabel);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task DeleteAsync(RecordLabel recordLabel, string cacheKey)
    {
        _unitOfWork.RecordLabels.Delete(recordLabel);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    } 

    private async Task<RecordLabel> GetRecordLabelAsync(int id)
    {
        var recordLabels = await _unitOfWork.RecordLabels.ByIdAsync(id);
        if (recordLabels == null)
        {
            throw new RecordLabelNotFoundException("Record label not found.");
        }

        return recordLabels;
    }

    #endregion

}