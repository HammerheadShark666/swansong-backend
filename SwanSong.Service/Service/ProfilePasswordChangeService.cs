using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service;

public class ProfilePasswordChangeService : IProfilePasswordChangeService
{
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<ProfilePasswordChangeRequest> _validatorHelper;

    public ProfilePasswordChangeService(IMapper mapper,
                                        IValidatorHelper<ProfilePasswordChangeRequest> validatorHelper, 
                                        IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<ProfilePasswordChangeActionResponse> UpdatePasswordAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        ProfilePasswordChangeRequest profilePasswordChange = _mapper.Map<ProfilePasswordChangeRequest>(profilePasswordChangeRequest);

        await BeforeProfilePasswordChangeAsync(profilePasswordChange);
        await UpdatePasswordAsync(profilePasswordChange.Id, profilePasswordChangeRequest);

        return await AfterProfilePasswordChangeAsync(profilePasswordChange); 
    }

    #endregion

    #region Private Functions

    private async Task BeforeProfilePasswordChangeAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        await _validatorHelper.ValidateAsync(profilePasswordChangeRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task<ProfilePasswordChangeActionResponse> AfterProfilePasswordChangeAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(profilePasswordChangeRequest, Constants.ValidationEventAfterSave);
        return new ProfilePasswordChangeActionResponse(ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task<Account> UpdatePasswordAsync(int id, ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        Account account = await GetAccountAsync(id);

        account = _mapper.Map<ProfilePasswordChangeRequest, Account>(profilePasswordChangeRequest, account);
        account.PasswordHash = BC.HashPassword(profilePasswordChangeRequest.Password);

        await UpdateAccountAsync(account);

        return account;
    }

    private async Task UpdateAccountAsync(Account account)
    {
        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.Complete();
    }

    private async Task<Account> GetAccountAsync(int id)
    {
        var account = await _unitOfWork.Accounts.ByIdAsync(id);
        if (account == null)
        {
            throw new KeyNotFoundException(ConstantMessages.ProfileNotFound);
        }

        return account;
    }

    #endregion

}