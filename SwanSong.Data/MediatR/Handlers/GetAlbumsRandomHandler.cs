using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumsRandomHandler : IRequestHandler<GetAlbumsRandomQuery, List<Album>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumsRandomHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<List<Album>> Handle(GetAlbumsRandomQuery query, CancellationToken cancellationToken)
    {
        return await _albumRepository.GetRandomAsync(query.NumberOfAlbums); 
    }
}