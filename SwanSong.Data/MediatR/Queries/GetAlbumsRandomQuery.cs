using MediatR;
using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetAlbumsRandomQuery : IRequest<List<Album>>
{
    public int NumberOfAlbums { get; set; }

    public GetAlbumsRandomQuery(int numberOfAlbums)
    {
        NumberOfAlbums = numberOfAlbums;
    }
}