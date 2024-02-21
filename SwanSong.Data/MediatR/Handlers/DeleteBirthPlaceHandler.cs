using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class DeleteBirthPlaceHandler : IRequestHandler<DeleteBirthPlaceCommand, BirthPlace>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public DeleteBirthPlaceHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }

    public async Task<BirthPlace> Handle(DeleteBirthPlaceCommand command, CancellationToken cancellationToken)
    { 
        return await _birthPlaceRepository.DeleteAsync(command.BirthPlace);
    }
}