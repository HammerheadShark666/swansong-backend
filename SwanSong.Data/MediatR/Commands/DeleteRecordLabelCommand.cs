using MediatR;

namespace SwanSong.Data.MediatR.Commands;

public class DeleteRecordLabelCommand : IRequest<int>
{
    public int Id { get; set; }

    public DeleteRecordLabelCommand(int id)
    {
        Id = id;
    }
}