using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class DeleteRecordLabelHandler : IRequestHandler<DeleteRecordLabelCommand, int>
{
    private readonly IRecordLabelRepository _recordLabelRepository;

    public DeleteRecordLabelHandler(IRecordLabelRepository recordLabelRepository)
    {
        _recordLabelRepository = recordLabelRepository;
    }

    public async Task<int> Handle(DeleteRecordLabelCommand command, CancellationToken cancellationToken)
    {
        var recordLabel = await _recordLabelRepository.ByIdAsync(command.Id);
        if (recordLabel == null)
            return default;

        return await _recordLabelRepository.DeleteAsync(recordLabel.Id);
    }
}