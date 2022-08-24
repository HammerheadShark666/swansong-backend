using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Helper;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;
using static SwanSong.Domain.Helper.Enums;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service
{
    public class RegisterService : BaseService<Register, RegisterDto>, IRegisterService
    {  
        public RegisterService(IMapper mapper,
                            IValidator<Register> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork, 
                            IAzureStorageBlobHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<RegisterDto> RegisterAsync(RegisterDto registerDto)
        {
            var register = _mapper.Map<Register>(registerDto);
             
            ValidationResult result = await BeforeSaveAsync(register);
            if (!result.IsValid)
                return GetDto(register, result.Errors, false); 

            Account account = await SaveAccountAsync(await CreateAccountAsync(register));
            SendVerificationEmail(account.Email, account.VerificationToken); 

            return GetDto(register, await AfterSaveAsync(register, null), true); 
        }
 
        public async Task<Account> CreateAccountAsync(Register model)
        {
            var account = _mapper.Map<Account>(model);

            var isFirstAccount = await _unitOfWork.Accounts.AnyAccountExistAsync(); 
            account.Role = isFirstAccount ? Role.Admin : Role.User;
            account.Created = DateTime.Now;
            account.VerificationToken = AuthenticationHelper.CreateRandomToken();
            account.PasswordHash = BC.HashPassword(model.Password);

            return account;
        }         

        private void SendVerificationEmail(string toEmail, string verificationToken)
        { 
            string message = !string.IsNullOrEmpty(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl())
                                  ? EmailMessages.VerifyEmailAddressEmail(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl(), verificationToken)
                                  : EmailMessages.VerifyEmailAddressNoVerifyUrlEmail(verificationToken);

            Send(toEmail, ConstantMessages.RegistrationVerifyEmailSubject, message);
        }
         
        public async Task<Account> SaveAccountAsync(Account account)
        {
            _unitOfWork.Accounts.Add(account);
            await _unitOfWork.Complete();

            return account;
        }
    }
}
