using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Helper;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Domain.Model.Profile;
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
    public readonly IValidatorHelper<ProfilePasswordChange> _validatorHelper;

    public ProfilePasswordChangeService(IMapper mapper,
                                        IValidatorHelper<ProfilePasswordChange> validatorHelper, 
                                        IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<ProfilePasswordChangeActionResponse> UpdatePasswordAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        ProfilePasswordChange profilePasswordChange = _mapper.Map<ProfilePasswordChange>(profilePasswordChangeRequest);

        await BeforeProfilePasswordChangeAsync(profilePasswordChange);
        await UpdatePasswordAsync(profilePasswordChange.Id, profilePasswordChangeRequest);

        return await AfterProfilePasswordChangeAsync(profilePasswordChange); 
    }

    #endregion

    #region Private Functions

    private async Task BeforeProfilePasswordChangeAsync(ProfilePasswordChange profilePasswordChange)
    {
        await _validatorHelper.ValidateAsync(profilePasswordChange, Constants.ValidationEventBeforeSave);
    }

    private async Task<ProfilePasswordChangeActionResponse> AfterProfilePasswordChangeAsync(ProfilePasswordChange profilePasswordChange)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(profilePasswordChange, Constants.ValidationEventAfterSave);
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