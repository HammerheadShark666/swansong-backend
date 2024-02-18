using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class DeleteStudioHandler : IRequestHandler<DeleteStudioCommand, int>
{
    private readonly IStudioRepository _studioRepository;

    public DeleteStudioHandler(IStudioRepository studioRepository)
    {
        _studioRepository = studioRepository;
    }

    public async Task<int> Handle(DeleteStudioCommand command, CancellationToken cancellationToken)
    {
        var studio = await _studioRepository.ByIdAsync(command.Id);
        if (studio == null)
            return default;

        return await _studioRepository.DeleteAsync(studio.Id);
    }
}