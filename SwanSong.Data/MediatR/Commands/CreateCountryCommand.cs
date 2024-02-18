using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class CreateCountryCommand : IRequest<Country>
{
    public string Name { get; set; }

    public CreateCountryCommand(string name)
    {
        Name = name;
    }
}