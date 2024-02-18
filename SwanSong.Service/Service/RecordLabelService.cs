using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.Helper;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class RecordLabelService : BaseService, IRecordLabelService
{ 
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<RecordLabel> _validatorHelper;
    private readonly IMediator _mediator;

    public RecordLabelService(IMapper mapper,
                              IValidatorHelper<RecordLabel> validatorHelper,
                              IMemoryCache memoryCache,
                              IMediator mediator) : base(memoryCache)
    {
        _validatorHelper = validatorHelper; 
        _mapper = mapper;
        _mediator = mediator;
    }

    #region Public Functions

    public async Task<List<RecordLabelResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<RecordLabelResponse>>(CacheKeys.RecordLabel, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<RecordLabelResponse>>(await _mediator.Send(new GetRecordLabelListQuery()));
        });
    } 

    public async Task<RecordLabelActionResponse> AddAsync(RecordLabelAddRequest recordLabelAddRequest)
    {
        var recordLabel = _mapper.Map<RecordLabel>(recordLabelAddRequest);

        await BeforeSaveAsync(recordLabel);
        recordLabel = await SaveAddAsync(recordLabel, CacheKeys.RecordLabel);

        return await AfterSaveAsync(recordLabel);
    }

    public async Task<RecordLabelActionResponse> UpdateAsync(RecordLabelUpdateRequest recordLabelUpdateRequest)
    {
        var recordLabel = await GetRecordLabelAsync(recordLabelUpdateRequest);

        await BeforeSaveAsync(recordLabel);
        recordLabel = await SaveUpdateAsync(recordLabel, CacheKeys.RecordLabel);

        return await AfterSaveAsync(recordLabel);
    }

    public async Task<RecordLabelActionResponse> DeleteAsync(int id)
    {
        var recordLabel = await GetRecordLabelAsync(id);

        await BeforeDeleteAsync(recordLabel);
        await DeleteAsync(id, CacheKeys.RecordLabel);

        return await AfterDeleteAsync(recordLabel);
    }

    #endregion

    #region Private Functions

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

    private async Task<RecordLabel> SaveAddAsync(RecordLabel recordLabel, string cacheKey)
    {
        recordLabel = await _mediator.Send(new CreateRecordLabelCommand(recordLabel.Name));
        ClearCache(cacheKey);
        return recordLabel;
    }

    private async Task<RecordLabel> SaveUpdateAsync(RecordLabel recordLabel, string cacheKey)
    {
        recordLabel = await _mediator.Send(new UpdateRecordLabelCommand(recordLabel.Id, recordLabel.Name));
        ClearCache(cacheKey);
        return recordLabel;
    }

    private async Task<int> DeleteAsync(int id, string cacheKey)
    {
        id = _mapper.Map<int>(await _mediator.Send(new DeleteRecordLabelCommand(id)));
        ClearCache(cacheKey);
        return id;
    }

    private async Task<RecordLabel> GetRecordLabelAsync(RecordLabelUpdateRequest recordLabelUpdateRequest)
    {
        var recordLabel = await _mediator.Send(new GetRecordLabelByIdQuery(recordLabelUpdateRequest.Id));
        return _mapper.Map(recordLabelUpdateRequest, recordLabel);
    }
    private async Task<RecordLabel> GetRecordLabelAsync(int id)
    {
        return await _mediator.Send(new GetRecordLabelByIdQuery(id));
    }
     
    #endregion

}