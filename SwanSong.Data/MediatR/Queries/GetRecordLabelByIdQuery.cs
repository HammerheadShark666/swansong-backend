using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Queries;

public class GetRecordLabelByIdQuery : IRequest<RecordLabel>
{
    public int Id { get; set; }

    public GetRecordLabelByIdQuery(int id)
    {
        Id = id;
    }
}