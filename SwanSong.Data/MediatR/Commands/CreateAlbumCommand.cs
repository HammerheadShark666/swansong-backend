using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class CreateAlbumCommand : IRequest<Album>
{
    public Album Album { get; set; }

    public CreateAlbumCommand(Album album)
    {
        Album = album;
    }
}