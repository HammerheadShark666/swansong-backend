using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumsByArtistHandler : IRequestHandler<GetAlbumsByArtistQuery, List<Album>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumsByArtistHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<List<Album>> Handle(GetAlbumsByArtistQuery query, CancellationToken cancellationToken)
    {
        return await _albumRepository.GetAlbumsForArtistAsync(query.ArtistId); 
    }
}