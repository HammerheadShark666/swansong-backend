using MediatR;
using SwanSong.Domain;

namespace SwanSong.Data.MediatR.Commands;

public class DeleteBirthPlaceCommand : IRequest<BirthPlace>
{
    public BirthPlace BirthPlace { get; set; }

    public DeleteBirthPlaceCommand(BirthPlace birthPlace)
    {
        BirthPlace = birthPlace;
    }
}