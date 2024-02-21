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

public class CountryService : BaseService, ICountryService
{
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Country> _validatorHelper;
    private readonly IMediator _mediator;

    public CountryService(IMapper mapper,
                          IValidatorHelper<Country> validatorHelper,
                          IMemoryCache memoryCache,
                          IMediator mediator) : base(memoryCache)
    {
        _validatorHelper = validatorHelper;
        _mapper = mapper;
        _mediator = mediator;
    }

    #region Public Functions

    public async Task<List<CountryResponse>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<CountryResponse>>(CacheKeys.Country, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return _mapper.Map<List<CountryResponse>>(await _mediator.Send(new GetCountryListQuery()));
        });
    }

    public async Task<CountryActionResponse> AddAsync(CountryAddRequest countryAddRequest)
    {
        var country = _mapper.Map<Country>(countryAddRequest);

        await BeforeSaveAsync(country);
        country = await SaveAddAsync(country, CacheKeys.Country);

        return await AfterSaveAsync(country);
    }

    public async Task<CountryActionResponse> UpdateAsync(CountryUpdateRequest countryUpdateRequest)
    {
        var country = await GetCountryAsync(countryUpdateRequest);

        await BeforeSaveAsync(country);
        country = await SaveUpdateAsync(country, CacheKeys.Country);

        return await AfterSaveAsync(country);
    }

    public async Task<CountryActionResponse> DeleteAsync(int id)
    {
        var country = await GetCountryAsync(id);

        await BeforeDeleteAsync(country);
        await DeleteAsync(id, CacheKeys.Country);

        return await AfterDeleteAsync(country);
    }

    #endregion

    #region Private Functions

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

    private async Task<Country> SaveAddAsync(Country country, string cacheKey)
    {
        country = await _mediator.Send(new CreateCountryCommand(country.Name));
        ClearCache(cacheKey);
        return country;
    }

    private async Task<Country> SaveUpdateAsync(Country country, string cacheKey)
    {
        country = await _mediator.Send(new UpdateCountryCommand(country.Id, country.Name));
        ClearCache(cacheKey);
        return country;
    }

    private async Task<int> DeleteAsync(int id, string cacheKey)
    {
        id = _mapper.Map<int>(await _mediator.Send(new DeleteCountryCommand(id)));
        ClearCache(cacheKey);
        return id;
    }

    private async Task<Country> GetCountryAsync(CountryUpdateRequest countryUpdateRequest)
    {
        //var country = await _mediator.Send(new GetCountryByIdQuery(countryUpdateRequest.Id));
        return _mapper.Map(countryUpdateRequest, await _mediator.Send(new GetCountryByIdQuery(countryUpdateRequest.Id)));
    }

    private async Task<Country> GetCountryAsync(int id)
    {
        return await _mediator.Send(new GetCountryByIdQuery(id));
    }

    #endregion

}