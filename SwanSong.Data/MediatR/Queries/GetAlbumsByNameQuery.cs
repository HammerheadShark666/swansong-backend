using MediatR;
using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetAlbumsByNameQuery : IRequest<List<Album>>
{
    public string Name { get; set; }

    public GetAlbumsByNameQuery(string name)
    {
        Name = name;
    }
}