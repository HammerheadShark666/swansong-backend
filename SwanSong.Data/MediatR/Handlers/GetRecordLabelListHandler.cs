using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetRecordLabelListHandler : IRequestHandler<GetRecordLabelListQuery, List<RecordLabel>>
{
    private readonly IRecordLabelRepository _recordLabelRepository;

    public GetRecordLabelListHandler(IRecordLabelRepository recordLabelRepository)
    {
        _recordLabelRepository = recordLabelRepository;
    }

    public async Task<List<RecordLabel>> Handle(GetRecordLabelListQuery query, CancellationToken cancellationToken)
    {
        return await _recordLabelRepository.AllAsync();
    }
}