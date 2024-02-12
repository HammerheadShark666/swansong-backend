using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class BirthPlaceValidator : BaseValidator<BirthPlace>
{
    private readonly IBirthPlaceRepository _birthPlaceRepository;

    public BirthPlaceValidator(IBirthPlaceRepository birthPlaceRepository)
    {
        _birthPlaceRepository = birthPlaceRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(birthPlace => birthPlace.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 100).WithMessage("Name length between 1 and 100.");                    

            RuleFor(birthPlace => birthPlace).MustAsync(async (birthPlace, cancellation) => {
                return await BirthPlaceNameExists(birthPlace);
            }).WithMessage(birthPlace => $"{birthPlace.Name} already exists.");
        });

        RuleSet("AfterSave", () => {

            RuleFor(birthPlace => birthPlace)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("The birth place has been saved.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {

            RuleFor(birthPlace => birthPlace)
                .Null()
                .WithSeverity(Severity.Info)
                .WithMessage("The birth place has been deleted.");
        });
    }

    protected async Task<bool> BirthPlaceNameExists(BirthPlace birthPlace)
    {
        return birthPlace.Id == 0
            ? !(await _birthPlaceRepository.ExistsAsync(birthPlace.Name))
            : !(await _birthPlaceRepository.ExistsAsync(birthPlace.Id, birthPlace.Name));
    }         
}
