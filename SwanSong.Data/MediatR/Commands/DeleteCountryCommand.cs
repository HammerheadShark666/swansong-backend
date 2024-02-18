using MediatR;

namespace SwanSong.Data.MediatR.Commands;

public class DeleteCountryCommand : IRequest<int>
{
    public int Id { get; set; }

    public DeleteCountryCommand(int id)
    {
        Id = id;
    }
}