using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Queries;

public class GetBirthPlaceByIdQuery : IRequest<BirthPlace>
{
    public int Id { get; set; }

    public GetBirthPlaceByIdQuery(int id)
    {
        Id = id;
    }
}