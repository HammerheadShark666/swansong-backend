using AutoMapper;
using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class UpdateAlbumPhotoHandler : IRequestHandler<UpdateAlbumCommand, Album>
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IMapper _mapper;

    public UpdateAlbumPhotoHandler(IAlbumRepository albumRepository,
                              IMapper mapper)
    {
        _albumRepository = albumRepository;
        _mapper = mapper;
    }

    public async Task<Album> Handle(UpdateAlbumCommand command, CancellationToken cancellationToken)
    { 
        await _albumRepository.UpdateAsync(command.Album);

        return command.Album;
    }
}
