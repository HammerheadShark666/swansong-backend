using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Domain.Model.Settings;
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
        private readonly JwtSettings _jwtSettings;
        private readonly AppSettings _appSettings;
        private readonly IOptions<SendGridSettings> _sendGridSettings;

        public ResetPasswordService(IMapper mapper,
                            IValidator<ResetPassword> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork,
                            IOptions<JwtSettings> jwtSettings,
                            IOptions<AppSettings> appSettings,
                            IOptions<SendGridSettings> sendGridSettings,
                            IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        {
            _jwtSettings = jwtSettings.Value;
            _appSettings = appSettings.Value;
            _sendGridSettings = sendGridSettings;
        }

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
              
            ValidationResult result = BeforeSave(resetPassword);
            if (!result.IsValid)
                return GetDto(resetPassword, result.Errors, false);
             
            _unitOfWork.Accounts.Update(await UpdateAccountAsync(resetPasswordDto.Token, resetPasswordDto.Password));
            await _unitOfWork.Complete();

            return GetDto(resetPassword, AfterSave(resetPassword, null), true);
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
            account.ResetTokenExpires = DateTime.Now.AddDays(_jwtSettings.ResetPasswordTokenExpiryDays);
            return account;
        }

        private void SendPasswordResetEmail(string toEmail, string resetToken)
        { 
            string message = !string.IsNullOrEmpty(_appSettings.ClientBaseUrl)
                                 ? EmailMessages.PasswordResetEmail(_appSettings.ClientBaseUrl, resetToken)
                                 : EmailMessages.PasswordResetNoResetUrlEmail(resetToken);

            Send(_sendGridSettings.Value, toEmail, ConstantMessages.ResetPasswordSubject, message);
        }
    }
}
