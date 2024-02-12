using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Model.Authentication;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class ResetPasswordValidator : BaseValidator<ResetPassword>
{
    private readonly IAccountRepository _accountRepository;

    public ResetPasswordValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(resetPassword => resetPassword.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.Password)
                .Equal(resetPassword => resetPassword.ConfirmPassword)
                .WithMessage("Password and Confirm Password must be same");

            RuleFor(resetPassword => resetPassword).MustAsync(async (resetPassword, cancellation) => {
                return await TokenValid(resetPassword);
            }).WithMessage("Token is invalid");
        });

        RuleSet("AfterSave", () => {

            RuleFor(resetPassword => resetPassword)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("Password has been reset.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {
             
        });
    }
  
    protected async Task<bool> TokenValid(ResetPassword resetPassword)
    {
        return await _accountRepository.ValidResetTokenAsync(resetPassword.Token);
    }        
}