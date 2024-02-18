using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetStudioByIdHandler : IRequestHandler<GetStudioByIdQuery, Studio>
{
    private readonly IStudioRepository _studentRepository;

    public GetStudioByIdHandler(IStudioRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<Studio> Handle(GetStudioByIdQuery query, CancellationToken cancellationToken)
    {
        var studio = await _studentRepository.ByIdAsync(query.Id);
        if (studio == null)
        {
            throw new StudioNotFoundException("Studio not found.");
        }

        return studio; 
    }
}