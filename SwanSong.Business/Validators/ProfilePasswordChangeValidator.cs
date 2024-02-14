using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Business.Validator;

public class ProfilePasswordChangeValidator : BaseValidator<ProfilePasswordChangeRequest>
{
    private readonly IAccountRepository _accountRepository;

    public ProfilePasswordChangeValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(profilePasswordChange => profilePasswordChange.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(profilePasswordChange => profilePasswordChange.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

            RuleFor(profilePasswordChange => profilePasswordChange.Password)
                .Equal(profilePasswordChange => profilePasswordChange.ConfirmPassword)
                .WithMessage("Password and Confirm Password must be same.");

            RuleFor(login => login).MustAsync(async (profilePasswordChange, cancellation) => {
                return await ValidAccountDetails(profilePasswordChange);
            }).WithMessage("Current password is invalid.");
        });

        RuleSet("AfterSave", () => {

            RuleFor(profilePasswordChange => profilePasswordChange)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("Password has been changed.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => { 

        });
    }

    protected async Task<bool> ValidAccountDetails(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        var account = await _accountRepository.GetAsync(profilePasswordChangeRequest.Email);
        if (account == null || !account.IsAuthenticated || !BC.Verify(profilePasswordChangeRequest.CurrentPassword, account.PasswordHash))
        {
            return false;
        }           

        return true;
    }
}
