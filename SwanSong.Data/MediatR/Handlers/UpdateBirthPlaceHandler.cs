using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class UpdateBirthPlaceHandler : IRequestHandler<UpdateBirthPlaceCommand, BirthPlace>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public UpdateBirthPlaceHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }
    public async Task<BirthPlace> Handle(UpdateBirthPlaceCommand command, CancellationToken cancellationToken)
    {
        var birthPlace = await _birthPlaceRepository.ByIdAsync(command.Id);
        if (birthPlace == null)
            return default;

        birthPlace.Name = command.Name;

        return await _birthPlaceRepository.UpdateAsync(birthPlace);
    }
}
