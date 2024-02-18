using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class UpdateRecordLabelHandler : IRequestHandler<UpdateRecordLabelCommand, RecordLabel>
{
    private readonly IRecordLabelRepository _recordLabelRepository;

    public UpdateRecordLabelHandler(IRecordLabelRepository recordLabelRepository)
    {
        _recordLabelRepository = recordLabelRepository;
    }
    public async Task<RecordLabel> Handle(UpdateRecordLabelCommand command, CancellationToken cancellationToken)
    {
        var recordLabel = await _recordLabelRepository.ByIdAsync(command.Id);
        if (recordLabel == null)
            return default;

        recordLabel.Name = command.Name;

        return await _recordLabelRepository.UpdateAsync(recordLabel);
    }
}
