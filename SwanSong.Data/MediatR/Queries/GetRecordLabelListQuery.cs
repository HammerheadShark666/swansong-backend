using MediatR;
using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetRecordLabelListQuery : IRequest<List<RecordLabel>> { }