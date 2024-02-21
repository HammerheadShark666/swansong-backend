using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class CreateAlbumHandler : IRequestHandler<CreateAlbumCommand, Album>
{
    private readonly IAlbumRepository _albumRepository;

    public CreateAlbumHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }
    public async Task<Album> Handle(CreateAlbumCommand command, CancellationToken cancellationToken)
    { 
        return await _albumRepository.AddAsync(command.Album);
    }
}