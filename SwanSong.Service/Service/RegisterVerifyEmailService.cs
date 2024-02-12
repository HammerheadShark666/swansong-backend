using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Helper;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class RegisterVerifyEmailService : IRegisterVerifyEmailService
{ 
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<RegisterVerifyEmail> _validatorHelper;

    public RegisterVerifyEmailService(IMapper mapper,
                                      IValidatorHelper<RegisterVerifyEmail> validatorHelper, 
                                      IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<RegisterVerifyEmailActionResponse> VerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    { 
        var registerVerifyEmail = _mapper.Map<RegisterVerifyEmail>(registerVerifyEmailRequest);

        await BeforeRegisterVerifyEmailAsync(registerVerifyEmail);
        Account account = await UpdateAccountAsync(registerVerifyEmail);

        return await AfterRegisterVerifyEmailAsync(registerVerifyEmail); 
    }

    #endregion

    #region Private Functions     

    private async Task BeforeRegisterVerifyEmailAsync(RegisterVerifyEmail registerVerifyEmail)
    {
        await _validatorHelper.ValidateAsync(registerVerifyEmail, Constants.ValidationEventBeforeSave);
    }

    private async Task<RegisterVerifyEmailActionResponse> AfterRegisterVerifyEmailAsync(RegisterVerifyEmail registerVerifyEmail)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(registerVerifyEmail, Constants.ValidationEventAfterSave);
        return new RegisterVerifyEmailActionResponse(ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task<Account> UpdateAccountAsync(RegisterVerifyEmail registerVerifyEmail)
    {
        var account = await _unitOfWork.Accounts.GetByVerificationTokenAsync(registerVerifyEmail.Token);
        account.Verified = DateTime.Now;
        account.VerificationToken = null;

        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.Complete();

        return account;
    }

    #endregion
}