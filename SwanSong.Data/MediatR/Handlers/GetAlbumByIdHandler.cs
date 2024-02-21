using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumByIdHandler : IRequestHandler<GetAlbumByIdQuery, Album>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumByIdHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Album> Handle(GetAlbumByIdQuery query, CancellationToken cancellationToken)
    { 
        var album = await _albumRepository.GetAsync(query.Id);
        if (album == null)
        {
            throw new AlbumNotFoundException("Album not found.");
        }

        return album; 
    }
}