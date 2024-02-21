using MediatR;
using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetAlbumsByArtistQuery : IRequest<List<Album>>
{
    public long ArtistId { get; set; }

    public GetAlbumsByArtistQuery(long artistId)
    {
        ArtistId = artistId;
    }
}