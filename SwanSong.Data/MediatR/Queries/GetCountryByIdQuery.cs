using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Queries;

public class GetCountryByIdQuery : IRequest<Country>
{
    public int Id { get; set; }

    public GetCountryByIdQuery(int id)
    {
        Id = id;
    }
}