using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Exceptions;
using SwanSong.Domain.Helper;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service;

public class ResetPasswordService : IResetPasswordService
{ 
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<ResetPassword> _validatorHelper;

    public ResetPasswordService(IMapper mapper,
                                IValidatorHelper<ResetPassword> validatorHelper, 
                                IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task ForgotPasswordAsync(ForgotPasswordRequest model)
    {
        var account = await _unitOfWork.Accounts.GetAsync(model.Email);
        if (account == null)
        {
            throw new AppException("Account not found");
        }
         
        await UpdateResetTokenAsync(GetResetToken(account));

        SendPasswordResetEmail(account.Email, account.ResetToken);
    }

    public async Task<ResetPasswordActionResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
    {
        var resetPassword = _mapper.Map<ResetPassword>(resetPasswordRequest);

        await BeforeResetPasswordAsync(resetPassword); ;
        await UpdateAccountAsync(resetPasswordRequest.Token, resetPasswordRequest.Password);

        return await AfterResetPasswordAsync(resetPassword); 
    }  
     
    public async Task ValidateResetTokenAsync(ValidateResetTokenRequest model)
    {
        if (!await _unitOfWork.Accounts.ValidResetTokenAsync(model.Token))
        {
            throw new AppException("Invalid token");
        }
    }

    #endregion

    #region Private Functions

    private async Task BeforeResetPasswordAsync(ResetPassword resetPassword)
    {
        await _validatorHelper.ValidateAsync(resetPassword, Constants.ValidationEventBeforeSave);
    }

    private async Task<ResetPasswordActionResponse> AfterResetPasswordAsync(ResetPassword resetPassword)
    { 
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(resetPassword, Constants.ValidationEventAfterSave);
        return new ResetPasswordActionResponse(ResponseHelper.GetMessages(afterSaveValidate.Errors), true); 
    }

    private async Task UpdateResetTokenAsync(Account account)
    {
        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.Complete();
    }

    private async Task UpdateAccountAsync(string token, string password)
    {
        _unitOfWork.Accounts.Update(await UpdateAccountRecordAsync(token, password));
        await _unitOfWork.Complete();
    }

    private async Task<Account> UpdateAccountRecordAsync(string resetToken, string password)
    {
        var account = await _unitOfWork.Accounts.GetByResetTokenAsync(resetToken);

        account.PasswordHash = BC.HashPassword(password);
        account.PasswordReset = DateTime.Now;
        account.ResetToken = null;
        account.ResetTokenExpires = null;

        return account;
    }

    private Account GetResetToken(Account account)
    {
        account.ResetToken = AuthenticationHelper.CreateRandomToken();
        account.ResetTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsPasswordTokenExpiryDays);
        
        return account;
    }

    private void SendPasswordResetEmail(string toEmail, string resetToken)
    { 
        string message = !string.IsNullOrEmpty(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl)
                             ? EmailMessages.PasswordResetEmail(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl, resetToken)
                             : EmailMessages.PasswordResetNoResetUrlEmail(resetToken);

        SmtpHelper.SendEmail(toEmail, ConstantMessages.PasswordResetEmailInstruction, message); 
    }

    #endregion
}