using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class CreateRecordLabelCommand : IRequest<RecordLabel>
{
    public string Name { get; set; }

    public CreateRecordLabelCommand(string name)
    {
        Name = name;
    }
}