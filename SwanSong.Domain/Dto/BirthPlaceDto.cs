using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class BirthPlaceDto : BaseDto
    {
        public int Id { get; set; }         
        public string Name { get; set; }         
        public CountryDto Country { get; set; }
        public BirthPlaceDto() { }
        public BirthPlaceDto(List<ValidationFailure> rules)
        { 
            Rules = rules; 
        } 
    }
}
