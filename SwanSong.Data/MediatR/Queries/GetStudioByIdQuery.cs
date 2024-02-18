using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Queries;

public class GetStudioByIdQuery : IRequest<Studio>
{
    public int Id { get; set; }

    public GetStudioByIdQuery(int id)
    {
        Id = id;
    }
}