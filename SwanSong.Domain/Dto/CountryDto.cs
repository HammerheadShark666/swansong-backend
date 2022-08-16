using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class CountryDto : BaseDto
    {
        public int Id { get; set; }         
        public string Name { get; set; }
        public CountryDto() { }
        public CountryDto(List<ValidationFailure> rules)
        {
            Rules = rules; 
        } 
    }
}
