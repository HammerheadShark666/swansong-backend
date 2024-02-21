using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumCountHandler : IRequestHandler<GetAlbumCountQuery, long>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumCountHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<long> Handle(GetAlbumCountQuery query, CancellationToken cancellationToken)
    {
        return await _albumRepository.CountAsync(); 
    }
}