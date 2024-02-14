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

namespace SwanSong.Service;

public class ProfileService : IProfileService
{ 
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<ProfileRequest> _validatorHelper;

    public ProfileService(IMapper mapper,
                          IValidatorHelper<ProfileRequest> validatorHelper, 
                          IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<ProfileResponse> GetAsync(int id)
    {
        return _mapper.Map<ProfileResponse>(await _unitOfWork.Accounts.ByIdAsync(id));
    }

    public async Task<ProfileActionResponse> UpdateAsync(int id, ProfileRequest profileRequest)
    { 
        profileRequest = profileRequest with { Id = id };

        await BeforeProfileUpdateAsync(profileRequest); 
        await UpdateAccountAsync(profileRequest);

        return await AfterProfileProfileAsync(profileRequest); 
    }

    #endregion

    #region Private Functions

    private async Task BeforeProfileUpdateAsync(ProfileRequest profileRequest)
    {
        await _validatorHelper.ValidateAsync(profileRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task<ProfileActionResponse> AfterProfileProfileAsync(ProfileRequest profileRequest)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(profileRequest, Constants.ValidationEventAfterSave);
        return new ProfileActionResponse(profileRequest.FirstName, profileRequest.LastName, profileRequest.Email, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task UpdateAccountAsync(ProfileRequest profileRequest)
    {
        Account account = await GetAccountAsync(profileRequest.Id);
        account = _mapper.Map<ProfileRequest, Account>(profileRequest, account);

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