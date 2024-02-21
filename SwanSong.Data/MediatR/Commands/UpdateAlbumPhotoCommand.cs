using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class UpdateAlbumPhotoCommand : IRequest<string>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateAlbumPhotoCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}