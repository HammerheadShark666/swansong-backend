using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Model.Authentication;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator
{
    public class RegisterValidator : BaseValidator<Register>
    {
        private readonly IAccountRepository _accountRepository;

        public RegisterValidator(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;

            RuleSet("BeforeSave", () => {

                RuleFor(register => register.Email)
                    .NotEmpty().WithMessage("Email is required.")
                    .Length(8, 150).WithMessage("Email length between 8 and 150.")
                    .EmailAddress().WithMessage("Invalid Email.");

                RuleFor(register => register.FirstName)
                    .NotEmpty().WithMessage("First Name is required.")
                    .Length(2, 50).WithMessage("First Name length between 2 and 50.");

                RuleFor(register => register.LastName)
                    .NotEmpty().WithMessage("Last Name is required.")
                    .Length(2, 50).WithMessage("Last Name length between 2 and 50.");

                RuleFor(register => register.Password)
                    .NotEmpty().WithMessage("Password is required.")
                    .Length(8, 50).WithMessage("Password length between 8 and 50.");

                RuleFor(register => register.ConfirmPassword)
                    .NotEmpty().WithMessage("Confirm Password is required.")
                    .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

                RuleFor(register => register.Password)
                    .Equal(register => register.ConfirmPassword)
                    .WithMessage("Password and Confirm Password must be same");

                RuleFor(register => register).MustAsync(async (register, cancellation) => {
                    return await EmailNameExists(register);
                }).WithMessage("Account with email already exists");
            });

            RuleSet("AfterSave", () => {

                RuleFor(register => register)
                   .Null()
                   .WithSeverity(Severity.Info)
                   .WithMessage("Registration successful, please check your email for verification instructions.");
            }); 
        }

        protected async Task<bool> EmailNameExists(Register register)
        {
            return !(await _accountRepository.AccountExistsAsync(register.Email));                
        }                    
    }
}