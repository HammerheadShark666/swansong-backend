using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumsByLetterHandler : IRequestHandler<GetAlbumsByLetterQuery, List<Album>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumsByLetterHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<List<Album>> Handle(GetAlbumsByLetterQuery query, CancellationToken cancellationToken)
    {
        return await _albumRepository.GetByLetterAsync(query.Letter); 
    }
}