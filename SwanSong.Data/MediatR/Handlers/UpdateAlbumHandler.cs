using AutoMapper;
using MediatR;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class UpdateAlbumHandler : IRequestHandler<UpdateAlbumCommand, Album>
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IMapper _mapper;

    public UpdateAlbumHandler(IAlbumRepository albumRepository,
                              IMapper mapper)
    {
        _albumRepository = albumRepository;
        _mapper = mapper;
    }

    public async Task<Album> Handle(UpdateAlbumCommand command, CancellationToken cancellationToken)
    { 
        return await _albumRepository.UpdateAsync(command.Album);         
    }
}
