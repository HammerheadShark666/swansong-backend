using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetRecordLabelByIdHandler : IRequestHandler<GetRecordLabelByIdQuery, RecordLabel>
{
    private readonly IRecordLabelRepository _recordLabelRepository;

    public GetRecordLabelByIdHandler(IRecordLabelRepository recordLabelRepository)
    {
        _recordLabelRepository = recordLabelRepository;
    }

    public async Task<RecordLabel> Handle(GetRecordLabelByIdQuery query, CancellationToken cancellationToken)
    {
        var recordLabel = await _recordLabelRepository.ByIdAsync(query.Id);
        if (recordLabel == null)
        {
            throw new RecordLabelNotFoundException("Record Label not found.");
        }

        return recordLabel; 
    }
}