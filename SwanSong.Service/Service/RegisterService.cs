using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;
using static SwanSong.Domain.Helper.Enums;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service;

public class RegisterService : IRegisterService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<RegisterRequest> _validatorHelper;

    public RegisterService(IMapper mapper,
                           IValidatorHelper<RegisterRequest> validatorHelper,
                           IMemoryCache memoryCache,
                           IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Private Functions

    public async Task<RegisterActionResponse> RegisterAsync(RegisterRequest registerRequest)
    {
        var register = _mapper.Map<RegisterRequest>(registerRequest);

        await BeforeRegisterAsync(registerRequest);
        Account account = await SaveAccountAsync(await CreateAccountAsync(registerRequest));

        SendVerificationEmail(account.Email, account.VerificationToken);

        return await AfterRegisterAsync(registerRequest);          
    }

    #endregion

    #region Private Functions

    private async Task BeforeRegisterAsync(RegisterRequest registerRequest)
    {
        await _validatorHelper.ValidateAsync(registerRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task<RegisterActionResponse> AfterRegisterAsync(RegisterRequest registerRequest)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(registerRequest, Constants.ValidationEventAfterSave);
        return new RegisterActionResponse(registerRequest.FirstName, registerRequest.LastName, registerRequest.Email,  ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task<Account> CreateAccountAsync(RegisterRequest registerRequest)
    {
        var account = _mapper.Map<Account>(registerRequest);

        var isFirstAccount = await _unitOfWork.Accounts.AnyAccountExistAsync(); 
        account.Role = isFirstAccount ? Role.Admin : Role.User;
        account.Created = DateTime.Now;
        account.VerificationToken = AuthenticationHelper.CreateRandomToken();
        account.PasswordHash = BC.HashPassword(registerRequest.Password);

        return account;
    }         

    private void SendVerificationEmail(string toEmail, string verificationToken)
    {  
        string message = !string.IsNullOrEmpty(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl)
                              ? EmailMessages.VerifyEmailAddressEmail(EnvironmentVariablesHelper.AppSettingsFrontEndBaseUrl, verificationToken)
                              : EmailMessages.VerifyEmailAddressNoVerifyUrlEmail(verificationToken); 

        SmtpHelper.SendEmail(toEmail, ConstantMessages.RegistrationVerifyEmailSubject, message); 
    }
     
    public async Task<Account> SaveAccountAsync(Account account)
    {
        _unitOfWork.Accounts.Add(account);
        await _unitOfWork.Complete();

        return account;
    }

    #endregion

}