using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class DeleteCountryHandler : IRequestHandler<DeleteCountryCommand, int>
{
    private readonly ICountryRepository _countryRepository;

    public DeleteCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<int> Handle(DeleteCountryCommand command, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.ByIdAsync(command.Id);
        if (country == null)
            return default;

        return await _countryRepository.DeleteAsync(country.Id);
    }
}