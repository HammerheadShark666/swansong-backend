using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetStudioListHandler : IRequestHandler<GetStudioListQuery, List<Studio>>
{
    private readonly IStudioRepository _studentRepository;

    public GetStudioListHandler(IStudioRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<List<Studio>> Handle(GetStudioListQuery query, CancellationToken cancellationToken)
    {
        return await _studentRepository.AllAsync();
    }
}