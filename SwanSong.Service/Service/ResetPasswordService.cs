using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Helper;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service
{
    public class ResetPasswordService : BaseService<ResetPassword, ResetPasswordDto>, IResetPasswordService
    {     
        public ResetPasswordService(IMapper mapper,
                            IValidator<ResetPassword> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork,            
                            IAzureStorageBlobHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        {}

        public async Task ForgotPasswordAsync(ForgotPasswordRequest model)
        {
            var account = await _unitOfWork.Accounts.GetAsync(model.Email);

            if (account == null)
                throw new AppException("Account not found");

            _unitOfWork.Accounts.Update(ResetToken(account));
            await _unitOfWork.Complete();

            SendPasswordResetEmail(account.Email, account.ResetToken);
        }

        public async Task<ResetPasswordDto> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
        {
            var resetPassword = _mapper.Map<ResetPassword>(resetPasswordDto);
              
            ValidationResult result = await BeforeSaveAsync(resetPassword);
            if (!result.IsValid)
                return GetDto(resetPassword, result.Errors, false);
             
            _unitOfWork.Accounts.Update(await UpdateAccountAsync(resetPasswordDto.Token, resetPasswordDto.Password));
            await _unitOfWork.Complete();

            return GetDto(resetPassword, await AfterSaveAsync(resetPassword, null), true);
        }  

        public async Task ValidateResetTokenAsync(ValidateResetTokenRequest model)
        {
            if (!await _unitOfWork.Accounts.ValidResetTokenAsync(model.Token))
                throw new AppException("Invalid token");
        }

        private async Task<Account> UpdateAccountAsync(string resetToken, string password)
        {
            var account = await _unitOfWork.Accounts.GetByResetTokenAsync(resetToken);

            account.PasswordHash = BC.HashPassword(password);
            account.PasswordReset = DateTime.Now;
            account.ResetToken = null;
            account.ResetTokenExpires = null;

            return account;
        }

        private Account ResetToken(Account account)
        {
            account.ResetToken = AuthenticationHelper.CreateRandomToken();
            account.ResetTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsPasswordTokenExpiryDays());
            return account;
        }

        private void SendPasswordResetEmail(string toEmail, string resetToken)
        { 
            string message = !string.IsNullOrEmpty(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl())
                                 ? EmailMessages.PasswordResetEmail(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl(), resetToken)
                                 : EmailMessages.PasswordResetNoResetUrlEmail(resetToken);

            Send(toEmail, ConstantMessages.ResetPasswordSubject, message);
        }
    }
}
