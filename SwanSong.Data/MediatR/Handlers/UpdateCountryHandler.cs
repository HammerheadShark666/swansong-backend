using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class UpdateCountryHandler : IRequestHandler<UpdateCountryCommand, Country>
{
    private readonly ICountryRepository _countryRepository;

    public UpdateCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    public async Task<Country> Handle(UpdateCountryCommand command, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.ByIdAsync(command.Id);
        if (country == null)
            return default;

        country.Name = command.Name;

        return await _countryRepository.UpdateAsync(country);
    }
}
