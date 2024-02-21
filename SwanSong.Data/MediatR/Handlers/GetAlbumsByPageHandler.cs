using MediatR;
using SwanSong.Data.MediatR.Queries;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SwanSong.Data.MediatR.Handlers;

public class GetAlbumsByPageHandler : IRequestHandler<GetAlbumsByPageQuery, List<Album>>
{
    private readonly IAlbumRepository _albumRepository;

    public GetAlbumsByPageHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<List<Album>> Handle(GetAlbumsByPageQuery query, CancellationToken cancellationToken)
    {
        return await _albumRepository.GetAllAsync(query.PaginationFilter.PageNumber, query.PaginationFilter.PageSize);
    }
}