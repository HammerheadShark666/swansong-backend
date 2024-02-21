using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class DeleteAlbumCommand : IRequest<Album>
{
    public Album Album { get; set; }

    public DeleteAlbumCommand(Album  album)
    {
        Album = album;
    }
}