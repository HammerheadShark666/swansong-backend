using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class CreateBirthPlaceCommand : IRequest<BirthPlace>
{
    public string Name { get; set; }

    public CreateBirthPlaceCommand(string name)
    {
        Name = name;
    }
}