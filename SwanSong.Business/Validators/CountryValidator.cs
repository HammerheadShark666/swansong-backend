using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class CountryValidator : BaseValidator<Country>
{
    private readonly ICountryRepository _countryRepository;
     
    public CountryValidator(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(country => country)
                .NotEmpty().WithMessage("Country not found.");

            RuleFor(country => country.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 50).WithMessage("Name length between 1 and 50.");

            RuleFor(country => country).MustAsync(async (country, cancellation) => {
                return await CountryNameExists(country);
            }).WithMessage(country => $"{country.Name} already exists.");
        });

        RuleSet("AfterSave", () => {

            RuleFor(country => country)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("The country has been saved.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {

            RuleFor(country => country)
                .Null()
                .WithSeverity(Severity.Info)
                .WithMessage("The country has been deleted.");
        });
    }

    protected async Task<bool> CountryNameExists(Country country)
    {
        return country.Id == 0
            ? !(await _countryRepository.ExistsAsync(country.Name))
            : !(await _countryRepository.ExistsAsync(country.Id, country.Name));
    }         
}
