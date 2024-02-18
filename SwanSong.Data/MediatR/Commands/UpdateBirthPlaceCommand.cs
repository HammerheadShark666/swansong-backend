using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class UpdateBirthPlaceCommand : IRequest<BirthPlace>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateBirthPlaceCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}