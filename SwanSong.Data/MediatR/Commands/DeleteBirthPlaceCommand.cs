using MediatR;

namespace SwanSong.Data.MediatR.Commands;

public class DeleteBirthPlaceCommand : IRequest<int>
{
    public int Id { get; set; }

    public DeleteBirthPlaceCommand(int id)
    {
        Id = id;
    }
}