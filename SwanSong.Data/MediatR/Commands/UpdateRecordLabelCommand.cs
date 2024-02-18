using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class UpdateRecordLabelCommand : IRequest<RecordLabel>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateRecordLabelCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}