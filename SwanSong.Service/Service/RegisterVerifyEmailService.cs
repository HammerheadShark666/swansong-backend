using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
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
    public readonly IValidatorHelper<RegisterVerifyEmailRequest> _validatorHelper;

    public RegisterVerifyEmailService(IMapper mapper,
                                      IValidatorHelper<RegisterVerifyEmailRequest> validatorHelper, 
                                      IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<RegisterVerifyEmailActionResponse> VerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    { 
        var registerVerifyEmail = _mapper.Map<RegisterVerifyEmailRequest>(registerVerifyEmailRequest);

        await BeforeRegisterVerifyEmailAsync(registerVerifyEmail);
        Account account = await UpdateAccountAsync(registerVerifyEmail);

        return await AfterRegisterVerifyEmailAsync(registerVerifyEmail); 
    }

    #endregion

    #region Private Functions     

    private async Task BeforeRegisterVerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        await _validatorHelper.ValidateAsync(registerVerifyEmailRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task<RegisterVerifyEmailActionResponse> AfterRegisterVerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(registerVerifyEmailRequest, Constants.ValidationEventAfterSave);
        return new RegisterVerifyEmailActionResponse(ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task<Account> UpdateAccountAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        var account = await _unitOfWork.Accounts.GetByVerificationTokenAsync(registerVerifyEmailRequest.Token);
        account.Verified = DateTime.Now;
        account.VerificationToken = null;

        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.CompleteAsync();

        return account;
    }

    #endregion
}