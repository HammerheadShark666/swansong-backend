using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class StudioValidator : BaseValidator<Studio>
{
    private readonly IStudioRepository _studioRepository;

    public StudioValidator(IStudioRepository studioRepository)
    {
        _studioRepository = studioRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(studio => studio.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 250).WithMessage("Name length between 1 and 250."); 

            RuleFor(studio => studio).MustAsync(async (studio, cancellation) => {
                return await StudioNameExists(studio);
            }).WithMessage(studio => $"{studio.Name} already exists.");
        });

        RuleSet("AfterSave", () => {

            RuleFor(studio => studio)
                .Null()
                .WithSeverity(Severity.Info)
                .WithMessage("The studio has been saved.");  
        });

        RuleSet("BeforeDelete", () => { 

        });

        RuleSet("AfterDelete", () => {

            RuleFor(studio => studio)
                .Null()
                .WithSeverity(Severity.Info)
                .WithMessage("The studio has been deleted.");
        });
    }

    protected async Task<bool> StudioNameExists(Studio studio)
    {
        return studio.Id == 0
            ? !(await _studioRepository.ExistsAsync(studio.Name))
            : !(await _studioRepository.ExistsAsync(studio.Id, studio.Name));
    }         
}
