using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class UpdateAlbumCommand : IRequest<Album>
{
    public Album Album { get; set; } 

    public UpdateAlbumCommand(Album album)
    {
        Album = album;
    }
}