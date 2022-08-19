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
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class RegisterVerifyEmailService : BaseService<RegisterVerifyEmail, RegisterVerifyEmailDto>, IRegisterVerifyEmailService
    {
        private readonly AppSettings _appSettings; 

        public RegisterVerifyEmailService(IMapper mapper,
                            IValidator<RegisterVerifyEmail> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork,
                            IOptions<AppSettings> appSettings,
                            IAzureStorageBlobHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        {
            _appSettings = appSettings.Value; 
        }          
         
        public async Task<RegisterVerifyEmailDto> VerifyEmailAsync(RegisterVerifyEmailDto registerVerifyEmailDto)
        { 
            var registerVerifyEmail = _mapper.Map<RegisterVerifyEmail>(registerVerifyEmailDto);
 
            ValidationResult result = await BeforeSaveAsync(registerVerifyEmail);
            if (!result.IsValid)
                return GetDto(registerVerifyEmail, result.Errors, false);

            Account account = await UpdateAccountAsync(registerVerifyEmail);

            return GetDto(registerVerifyEmail, await AfterSaveAsync(registerVerifyEmail, null), true);
        }  

        public async Task<Account> UpdateAccountAsync(RegisterVerifyEmail registerVerifyEmail)
        {
            var account = await _unitOfWork.Accounts.GetByVerificationTokenAsync(registerVerifyEmail.Token);
            account.Verified = DateTime.Now;
            account.VerificationToken = null;

            _unitOfWork.Accounts.Update(account);
            await _unitOfWork.Complete();

            return account;
        }
    }
}
