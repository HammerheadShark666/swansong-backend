using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Helper;
using SwanSong.Domain.Model.Authentication;
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
    public readonly IValidatorHelper<Register> _validatorHelper;

    public RegisterService(IMapper mapper,
                           IValidatorHelper<Register> validatorHelper,
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
        var register = _mapper.Map<Register>(registerRequest);

        await BeforeRegisterAsync(register);
        Account account = await SaveAccountAsync(await CreateAccountAsync(register));

        SendVerificationEmail(account.Email, account.VerificationToken);

        return await AfterRegisterAsync(register);          
    }

    #endregion

    #region Private Functions

    private async Task BeforeRegisterAsync(Register register)
    {
        await _validatorHelper.ValidateAsync(register, Constants.ValidationEventBeforeSave);
    }

    private async Task<RegisterActionResponse> AfterRegisterAsync(Register register)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(register, Constants.ValidationEventAfterSave);
        return new RegisterActionResponse(register.FirstName, register.LastName, register.Email,  ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task<Account> CreateAccountAsync(Register model)
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