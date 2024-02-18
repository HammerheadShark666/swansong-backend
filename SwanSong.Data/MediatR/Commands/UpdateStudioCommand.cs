using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class UpdateStudioCommand : IRequest<Studio>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateStudioCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}