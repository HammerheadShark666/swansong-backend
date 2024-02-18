using MediatR;

namespace SwanSong.Data.MediatR.Commands;

public class DeleteStudioCommand : IRequest<int>
{
    public int Id { get; set; }

    public DeleteStudioCommand(int id)
    {
        Id = id;
    }
}