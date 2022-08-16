using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto
{
    public class RecordLabelDto : BaseDto
    {
        public int Id { get; set; }         
        public string Name { get; set; }
        public RecordLabelDto() { }
        public RecordLabelDto(List<ValidationFailure> rules)
        {
            Rules = rules; 
        } 
    }
}
