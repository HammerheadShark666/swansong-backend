using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Queries;

public class GetAlbumByIdQuery : IRequest<Album>
{
    public long Id { get; set; }

    public GetAlbumByIdQuery(long id)
    {
        Id = id;
    }
}