using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class DeleteBirthPlaceHandler : IRequestHandler<DeleteBirthPlaceCommand, int>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public DeleteBirthPlaceHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }

    public async Task<int> Handle(DeleteBirthPlaceCommand command, CancellationToken cancellationToken)
    {
        var birthPlace = await _birthPlaceRepository.ByIdAsync(command.Id);
        if (birthPlace == null)
            return default;

        return await _birthPlaceRepository.DeleteAsync(birthPlace.Id);
    }
}