using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class MemberDto : BaseDto
    {
        public long Id { get; set; }
        public long ArtistId { get; set; }         
        public string StageName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public int? BirthPlaceId { get; set; }
#nullable enable
        public BirthPlaceDto? BirthPlace { get; set; }
#nullable disable

        public MemberDto() { }
        public MemberDto(List<ValidationFailure> rules)
        {
            Rules = rules; 
        }
    }
}
