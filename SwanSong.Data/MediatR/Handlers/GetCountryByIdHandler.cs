using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, Country>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountryByIdHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<Country> Handle(GetCountryByIdQuery query, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.ByIdAsync(query.Id);
        if (country == null)
        {
            throw new CountryNotFoundException("Country not found.");
        }

        return country; 
    }
}