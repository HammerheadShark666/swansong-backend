using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetBirthPlaceListHandler : IRequestHandler<GetBirthPlaceListQuery, List<BirthPlace>>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public GetBirthPlaceListHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }

    public async Task<List<BirthPlace>> Handle(GetBirthPlaceListQuery query, CancellationToken cancellationToken)
    {
        return await _birthPlaceRepository.AllAsync();
    }
}