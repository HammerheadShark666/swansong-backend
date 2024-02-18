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

public class StudioService : BaseService, IStudioService
{ 
    private readonly IMapper _mapper;
    private readonly IValidatorHelper<Studio> _validatorHelper; 
    private readonly IMediator _mediator;

    public StudioService(IMapper mapper,
                         IValidatorHelper<Studio> validatorHelper,
                         IMemoryCache memoryCache,
                         IMediator mediator) : base(memoryCache)
    {
        _validatorHelper = validatorHelper; 
        _mapper = mapper;
        _mediator = mediator;
    }

    #region Public Functions

    public async Task<List<StudioResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<StudioResponse>>(CacheKeys.Studio, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<StudioResponse>>(await _mediator.Send(new GetStudioListQuery())); 
        });
    } 

    public async Task<StudioActionResponse> AddAsync(StudioAddRequest studioAddRequest)
    {
        var studio = _mapper.Map<Studio>(studioAddRequest);

        await BeforeSaveAsync(studio); 
        studio = await SaveAddAsync(studio, CacheKeys.Studio);

        return await AfterSaveAsync(studio); 
    }

    public async Task<StudioActionResponse> UpdateAsync(StudioUpdateRequest studioUpdateRequest)
    {
        var studio = await GetStudioAsync(studioUpdateRequest);

        await BeforeSaveAsync(studio);
        studio = await SaveUpdateAsync(studio, CacheKeys.Studio);

        return await AfterSaveAsync(studio); 
    }

    public async Task<StudioActionResponse> DeleteAsync(int id)
    { 
        var studio = await GetStudioAsync(id);

        await BeforeDeleteAsync(studio);
        await DeleteAsync(id, CacheKeys.Studio);

        return await AfterDeleteAsync(studio);
    }

    #endregion

    #region Private Functions
     
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

    private async Task<Studio> SaveAddAsync(Studio studio, string cacheKey)
    {
        studio = await _mediator.Send(new CreateStudioCommand(studio.Name));
        ClearCache(cacheKey);
        return studio;
    }

    private async Task<Studio> SaveUpdateAsync(Studio studio, string cacheKey)
    {
        studio = await _mediator.Send(new UpdateStudioCommand(studio.Id, studio.Name));
        ClearCache(cacheKey);
        return studio;         
    }   

    private async Task<int> DeleteAsync(int id, string cacheKey)
    {
        id =  _mapper.Map<int>(await _mediator.Send(new DeleteStudioCommand(id)));
        ClearCache(cacheKey);       
        return id; 
    } 

    private async Task<Studio> GetStudioAsync(StudioUpdateRequest studioUpdateRequest)
    {
        var studio = await _mediator.Send(new GetStudioByIdQuery(studioUpdateRequest.Id));
        return _mapper.Map(studioUpdateRequest, studio);
    }
    private async Task<Studio> GetStudioAsync(int id)
    {
        return await _mediator.Send(new GetStudioByIdQuery(id));
    }

    #endregion
}