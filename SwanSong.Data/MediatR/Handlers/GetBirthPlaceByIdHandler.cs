using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetBirthPlaceByIdHandler : IRequestHandler<GetBirthPlaceByIdQuery, BirthPlace>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public GetBirthPlaceByIdHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }

    public async Task<BirthPlace> Handle(GetBirthPlaceByIdQuery query, CancellationToken cancellationToken)
    {
        var birthPlace = await _birthPlaceRepository.ByIdAsync(query.Id);
        if (birthPlace == null)
        {
            throw new BirthPlaceNotFoundException("BirthPlace not found.");
        }

        return birthPlace; 
    }
}