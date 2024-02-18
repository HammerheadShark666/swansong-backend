using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class CreateRecordLabelHandler : IRequestHandler<CreateRecordLabelCommand, RecordLabel>
{
    private readonly IRecordLabelRepository _recordLabelRepository;

    public CreateRecordLabelHandler(IRecordLabelRepository recordLabelRepository)
    {
        _recordLabelRepository = recordLabelRepository;
    }
    public async Task<RecordLabel> Handle(CreateRecordLabelCommand command, CancellationToken cancellationToken)
    {
        var recordLabel = new RecordLabel()
        {
            Name = command.Name
        };

        return await _recordLabelRepository.AddAsync(recordLabel);
    }
}