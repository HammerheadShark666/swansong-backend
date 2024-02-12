using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Model.Profile;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class ProfileValidator : BaseValidator<Profile>
{
    private readonly IAccountRepository _accountRepository;

    public ProfileValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(profile => profile.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Length(8, 150).WithMessage("Email length between 8 and 150.")
                .EmailAddress().WithMessage("Invalid Email.");

            RuleFor(profile => profile.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .Length(2, 50).WithMessage("First Name length between 2 and 50.");

            RuleFor(profile => profile.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .Length(2, 50).WithMessage("Last Name length between 2 and 50.");

            RuleFor(register => register).MustAsync(async (register, cancellation) => {
                return await EmailNameExists(register);
            }).WithMessage("Account with email already exists");
        });

        RuleSet("AfterSave", () => {

            RuleFor(profile => profile)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("Profile has been saved.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {

        });
    }

    protected async Task<bool> EmailNameExists(Profile profile)
    {
        return !(await _accountRepository.AccountExistsAsync(profile.Email, profile.Id));
    }
}
