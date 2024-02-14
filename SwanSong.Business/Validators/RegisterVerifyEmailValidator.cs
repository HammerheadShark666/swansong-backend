using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class RegisterVerifyEmailValidator : BaseValidator<RegisterVerifyEmailRequest>
{
    private readonly IAccountRepository _accountRepository;

    public RegisterVerifyEmailValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(registerVerifyEmail => registerVerifyEmail.Token)
                .NotEmpty().WithMessage("Token is required."); 
             
            RuleFor(registerVerifyEmail => registerVerifyEmail).MustAsync(async (registerVerifyEmail, cancellation) => {
                return await AccountWithTokenExists(registerVerifyEmail);
            }).WithMessage("Token is invalid");
        });

        RuleSet("AfterSave", () => {

            RuleFor(register => register)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("Registration successful.");
        }); 
    }

    protected async Task<bool> AccountWithTokenExists(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        return (await _accountRepository.GetByVerificationTokenAsync(registerVerifyEmailRequest.Token) != null);                
    }                    
}
