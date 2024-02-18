using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class UpdateCountryCommand : IRequest<Country>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateCountryCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}