using MediatR;
using SwanSong.Domain;
using SwanSong.Helper.Filter;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetAlbumsByPageQuery : IRequest<List<Album>>
{
    public PaginationFilter PaginationFilter { get; set; }

    public GetAlbumsByPageQuery(PaginationFilter paginationFilter)
    {
        PaginationFilter = paginationFilter;
    }
}