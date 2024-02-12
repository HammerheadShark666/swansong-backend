using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Helper;
using SwanSong.Domain.Model.Profile;
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
    public readonly IValidatorHelper<Domain.Model.Profile.Profile> _validatorHelper;

    public ProfileService(IMapper mapper,
                          IValidatorHelper<Domain.Model.Profile.Profile> validatorHelper, 
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
        Domain.Model.Profile.Profile profile = _mapper.Map<Domain.Model.Profile.Profile>(profileRequest);
        profile.Id = id;

        await BeforeProfileUpdateAsync(profile);
        await UpdateAccountAsync(profile.Id, profileRequest);

        return await AfterProfileProfileAsync(profile); 
    }

    #endregion

    #region Private Functions

    private async Task BeforeProfileUpdateAsync(Domain.Model.Profile.Profile profile)
    {
        await _validatorHelper.ValidateAsync(profile, Constants.ValidationEventBeforeSave);
    }

    private async Task<ProfileActionResponse> AfterProfileProfileAsync(Domain.Model.Profile.Profile profile)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(profile, Constants.ValidationEventAfterSave);
        return new ProfileActionResponse(profile.FirstName, profile.LastName, profile.Email, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task UpdateAccountAsync(int id, ProfileRequest profileRequest)
    {
        Account account = await GetAccountAsync(id);
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