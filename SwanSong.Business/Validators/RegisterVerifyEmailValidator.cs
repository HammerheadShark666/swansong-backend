﻿using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Model.Authentication;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator
{
    public class RegisterVerifyEmailValidator : BaseValidator<RegisterVerifyEmail>
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

        protected async Task<bool> AccountWithTokenExists(RegisterVerifyEmail registerVerifyEmail)
        {
            return (await _accountRepository.GetByVerificationTokenAsync(registerVerifyEmail.Token) != null);                
        }                    
    }
}
