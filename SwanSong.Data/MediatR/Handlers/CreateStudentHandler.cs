using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class CreateStudioHandler : IRequestHandler<CreateStudioCommand, Studio>
{
    private readonly IStudioRepository _studentRepository;

    public CreateStudioHandler(IStudioRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<Studio> Handle(CreateStudioCommand command, CancellationToken cancellationToken)
    {
        var studio = new Studio()
        {
            Name = command.Name
        };

        return await _studentRepository.AddAsync(studio);
    }
}