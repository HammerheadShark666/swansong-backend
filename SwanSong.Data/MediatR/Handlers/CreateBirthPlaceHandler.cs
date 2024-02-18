using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class CreateBirthPlaceHandler : IRequestHandler<CreateBirthPlaceCommand, BirthPlace>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public CreateBirthPlaceHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }
    public async Task<BirthPlace> Handle(CreateBirthPlaceCommand command, CancellationToken cancellationToken)
    {
        var birthPlace = new BirthPlace()
        {
            Name = command.Name
        };

        return await _birthPlaceRepository.AddAsync(birthPlace);
    }
}