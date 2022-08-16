using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class SongDto : BaseDto
    {
        public long Id { get; set; }         
        public string Title { get; set; }         
        public string Length { get; set; } 
        public List<AlbumSongDto> AlbumSong { get; set; }
        public SongDto() { }
        public SongDto(List<ValidationFailure> rules)
        {
            Rules = rules;
        }
    }
}
