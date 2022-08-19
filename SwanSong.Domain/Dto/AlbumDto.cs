using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class AlbumDto : BaseDto
    {
        public long Id { get; set; }         
        public string Name { get; set; }         
        public long? ArtistId { get; set; }
        public string ArtistName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? RecordedDate { get; set; }
        public int? LabelId { get; set; }
        public string LabelName { get; set; }
        public int? StudioId { get; set; }
        public Studio Studio { get; set; }         
        public string Producers { get; set; } 
        public string Arrangers { get; set; }         
        public string Engineers { get; set; }         
        public string Artwork { get; set; }                 
        public string Photo { get; set; }
        public List<AlbumSongDto> Songs { get; set; }
          
        public AlbumDto() 
        {
            IsValid = true;
        }
        public AlbumDto(List<ValidationFailure> rules)    
        {
            Rules = rules; 
        } 
    }
}
