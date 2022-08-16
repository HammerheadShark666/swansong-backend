using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class ArtistDto : BaseDto
    {
        public long Id { get; set; }            
        public string Name { get; set; }
        public string Photo { get; set; }
        public int? FormationYear { get; set; }
        public int? DisbandYear { get; set; }
        public int? CountryId { get; set; }
        public List<Member> Members { get; set; }
        public List<Album> Albums { get; set; }
        public ArtistDto() { }
        public ArtistDto(List<ValidationFailure> rules)
        {
            Rules = rules; 
        }
    }
}
