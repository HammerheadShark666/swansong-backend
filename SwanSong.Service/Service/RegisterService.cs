using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Domain.Model.Settings;
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
        private readonly AppSettings _appSettings;
        private readonly IOptions<SendGridSettings> _sendGridSettings;

        public RegisterService(IMapper mapper,
                            IValidator<Register> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork,
                            IOptions<AppSettings> appSettings,
                            IOptions<SendGridSettings> sendGridSettings,
                            IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        {
            _appSettings = appSettings.Value;
            _sendGridSettings = sendGridSettings;
        }

        public async Task<RegisterDto> RegisterAsync(RegisterDto registerDto)
        {
            var register = _mapper.Map<Register>(registerDto);
             
            ValidationResult result = BeforeSave(register);
            if (!result.IsValid)
                return GetDto(register, result.Errors, false); 

            Account account = await SaveAccountAsync(await CreateAccountAsync(register));
            SendVerificationEmail(account.Email, account.VerificationToken); 

            return GetDto(register, AfterSave(register, null), true); 
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
            string message = !string.IsNullOrEmpty(_appSettings.ClientBaseUrl)
                                  ? EmailMessages.VerifyEmailAddressEmail(_appSettings.ClientBaseUrl, verificationToken)
                                  : EmailMessages.VerifyEmailAddressNoVerifyUrlEmail(verificationToken);

            Send(_sendGridSettings.Value, toEmail, ConstantMessages.RegistrationVerifyEmailSubject, message);
        }
         
        public async Task<Account> SaveAccountAsync(Account account)
        {
            _unitOfWork.Accounts.Add(account);
            await _unitOfWork.Complete();

            return account;
        }
    }
}
