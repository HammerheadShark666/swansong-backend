using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;


public class BirthPlaceCommandHandler :
    ICommandHandler<CreateBirthPlaceCommand>,
    ICommandHandler<UpdateBirthPlaceCommand>,
    ICommandHandler<DeleteBirthPlaceCommand>,
    ICommandHandler<GetBirthPlaceByIdQuery>,
    ICommandHandler<GetBirthPlaceListQuery>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public BirthPlaceCommandHandler(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;
    }

    async Task<BirthPlace> Handle(CreateBirthPlaceCommand command)
    {
        var birthPlace = new BirthPlace()
        {
            Name = command.Name
        };

        return await _birthPlaceRepository.AddAsync(birthPlace);
    }

    async Task<BirthPlace> Handle(UpdateBirthPlaceCommand command)
    {
        var birthPlace = await _birthPlaceRepository.ByIdAsync(command.Id);
        if (birthPlace == null)
            return default;

        birthPlace.Name = command.Name;

        return await _birthPlaceRepository.UpdateAsync(birthPlace);
    }

    async Task<BirthPlace> Handle(DeleteBirthPlaceCommand command)
    {
        return await _birthPlaceRepository.DeleteAsync(command.BirthPlace);
    }

    async Task<BirthPlace> Handle(GetBirthPlaceByIdQuery query)
    {
        var birthPlace = await _birthPlaceRepository.ByIdAsync(query.Id);
        if (birthPlace == null)
        {
            throw new BirthPlaceNotFoundException("BirthPlace not found.");
        }

        return birthPlace;
    }

    async Task<List<BirthPlace>> Handle(GetBirthPlaceListQuery command)
    {
        return await _birthPlaceRepository.AllAsync();
    }
}