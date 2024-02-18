using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetCountryListHandler : IRequestHandler<GetCountryListQuery, List<Country>>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountryListHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<List<Country>> Handle(GetCountryListQuery query, CancellationToken cancellationToken)
    {
        return await _countryRepository.AllAsync();
    }
}