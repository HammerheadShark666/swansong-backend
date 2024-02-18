using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class UpdateStudioHandler : IRequestHandler<UpdateStudioCommand, Studio>
{
    private readonly IStudioRepository _studioRepository;

    public UpdateStudioHandler(IStudioRepository studioRepository)
    {
        _studioRepository = studioRepository;
    }
    public async Task<Studio> Handle(UpdateStudioCommand command, CancellationToken cancellationToken)
    {
        var studio = await _studioRepository.ByIdAsync(command.Id);
        if (studio == null)
            return default;

        studio.Name = command.Name;

        return await _studioRepository.UpdateAsync(studio);
    }
}
