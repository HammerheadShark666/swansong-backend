using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class StudioDto : BaseDto
    {
        public int Id { get; set; }         
        public string Name { get; set; }
        public StudioDto() { }
        public StudioDto(List<ValidationFailure> rules)
        {
            Rules = rules; 
        }
    }
}
