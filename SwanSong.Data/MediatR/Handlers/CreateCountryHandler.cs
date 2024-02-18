using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class CreateCountryHandler : IRequestHandler<CreateCountryCommand, Country>
{
    private readonly ICountryRepository _countryRepository;

    public CreateCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    public async Task<Country> Handle(CreateCountryCommand command, CancellationToken cancellationToken)
    {
        var country = new Country()
        {
            Name = command.Name
        };

        return await _countryRepository.AddAsync(country);
    }
}