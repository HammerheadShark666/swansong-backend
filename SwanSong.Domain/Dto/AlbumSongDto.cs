using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class AlbumSongDto : BaseDto
    {
        public long Id { get; set; }
        public int Side { get; set; }
        public int Order { get; set; }
        public long AlbumId { get; set; }
        public SongDto Song { get; set; }
        public AlbumSongDto() { }
        public AlbumSongDto(List<ValidationFailure> rules)
        {
            Rules = rules;
        }
    }
}
