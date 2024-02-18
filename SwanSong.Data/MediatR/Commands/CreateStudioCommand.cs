using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class CreateStudioCommand : IRequest<Studio>
{
    public string Name { get; set; }

    public CreateStudioCommand(string name)
    {
        Name = name;
    }
}