using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator
{
    public class RecordLabelValidator : BaseValidator<RecordLabel>
    {
        private readonly IRecordLabelRepository _recordLabelRepository;

        public RecordLabelValidator(IRecordLabelRepository recordLabelRepository)
        {
            _recordLabelRepository = recordLabelRepository;

            RuleSet("BeforeSave", () => {

                RuleFor(recordLabel => recordLabel)
                    .NotEmpty().WithMessage("Record label not found.");

                RuleFor(recordLabel => recordLabel.Name)
                    .NotEmpty().WithMessage("Name is required.")
                    .Length(1, 100).WithMessage("Name length between 1 and 100.");
                 
                RuleFor(recordLabel => recordLabel).MustAsync(async (recordLabel, cancellation) => {
                    return await RecordLabelNameExists(recordLabel);
                }).WithMessage(recordLabel => $"{recordLabel.Name} already exists.");
            });

            RuleSet("AfterSave", () => {

                RuleFor(recordLabel => recordLabel)
                    .Null()
                    .WithSeverity(Severity.Info)
                    .WithMessage("The record label has been saved.");
            });

            RuleSet("BeforeDelete", () => {
 
            });

            RuleSet("AfterDelete", () => {

                RuleFor(recordLabel => recordLabel)
                    .Null()
                    .WithSeverity(Severity.Info)
                    .WithMessage("The record label has been deleted.");
            });
        }

        protected async Task<bool> RecordLabelNameExists(RecordLabel recordLabel)
        {
            return recordLabel.Id == 0 
                ? !(await _recordLabelRepository.ExistsAsync(recordLabel.Name))
                : !(await _recordLabelRepository.ExistsAsync(recordLabel.Id, recordLabel.Name));
        }         
    }
}
