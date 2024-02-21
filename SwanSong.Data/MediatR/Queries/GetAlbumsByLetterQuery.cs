using MediatR;
using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetAlbumsByLetterQuery : IRequest<List<Album>>
{
    public string Letter { get; set; }

    public GetAlbumsByLetterQuery(string letter)
    {
        Letter = letter;
    }
}