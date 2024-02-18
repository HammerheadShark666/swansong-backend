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

public class BirthPlaceService : BaseService, IBirthPlaceService
{
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<BirthPlace> _validatorHelper;
    private readonly IMediator _mediator;

    public BirthPlaceService(IMapper mapper,
                              IValidatorHelper<BirthPlace> validatorHelper,
                              IMemoryCache memoryCache,
                              IMediator mediator) : base(memoryCache)
    {
        _validatorHelper = validatorHelper;
        _mapper = mapper;
        _mediator = mediator;
    }

    #region Public Functions

    public async Task<List<BirthPlaceResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<BirthPlaceResponse>>(CacheKeys.BirthPlace, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<BirthPlaceResponse>>(await _mediator.Send(new GetBirthPlaceListQuery()));
        });
    }

    public async Task<BirthPlaceActionResponse> AddAsync(BirthPlaceAddRequest birthPlaceAddRequest)
    {
        var birthPlace = _mapper.Map<BirthPlace>(birthPlaceAddRequest);

        await BeforeSaveAsync(birthPlace);
        birthPlace = await SaveAddAsync(birthPlace, CacheKeys.BirthPlace);

        return await AfterSaveAsync(birthPlace);
    }

    public async Task<BirthPlaceActionResponse> UpdateAsync(BirthPlaceUpdateRequest birthPlaceUpdateRequest)
    {
        var birthPlace = await GetBirthPlaceAsync(birthPlaceUpdateRequest);

        await BeforeSaveAsync(birthPlace);
        birthPlace = await SaveUpdateAsync(birthPlace, CacheKeys.BirthPlace);

        return await AfterSaveAsync(birthPlace);
    }

    public async Task<BirthPlaceActionResponse> DeleteAsync(int id)
    {
        var birthPlace = await GetBirthPlaceAsync(id);

        await BeforeDeleteAsync(birthPlace);
        await DeleteAsync(id, CacheKeys.BirthPlace);

        return await AfterDeleteAsync(birthPlace);
    }

    #endregion

    #region Private Functions

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

    private async Task<BirthPlace> SaveAddAsync(BirthPlace birthPlace, string cacheKey)
    {
        birthPlace = await _mediator.Send(new CreateBirthPlaceCommand(birthPlace.Name));
        ClearCache(cacheKey);
        return birthPlace;
    }

    private async Task<BirthPlace> SaveUpdateAsync(BirthPlace birthPlace, string cacheKey)
    {
        birthPlace = await _mediator.Send(new UpdateBirthPlaceCommand(birthPlace.Id, birthPlace.Name));
        ClearCache(cacheKey);
        return birthPlace;
    }

    private async Task<int> DeleteAsync(int id, string cacheKey)
    {
        id = _mapper.Map<int>(await _mediator.Send(new DeleteBirthPlaceCommand(id)));
        ClearCache(cacheKey);
        return id;
    }

    private async Task<BirthPlace> GetBirthPlaceAsync(BirthPlaceUpdateRequest birthPlaceUpdateRequest)
    {
        var birthPlace = await _mediator.Send(new GetBirthPlaceByIdQuery(birthPlaceUpdateRequest.Id));
        return _mapper.Map(birthPlaceUpdateRequest, birthPlace);
    }
    private async Task<BirthPlace> GetBirthPlaceAsync(int id)
    {
        return await _mediator.Send(new GetBirthPlaceByIdQuery(id));
    }

    #endregion

}