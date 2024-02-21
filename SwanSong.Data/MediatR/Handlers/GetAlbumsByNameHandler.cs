using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumsByNameHandler : IRequestHandler<GetAlbumsByNameQuery, List<Album>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumsByNameHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<List<Album>> Handle(GetAlbumsByNameQuery query, CancellationToken cancellationToken)
    {
        return await _albumRepository.GetByNameAsync(query.Name); 
    }
}