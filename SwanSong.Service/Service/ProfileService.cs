using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Profile;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class ProfileService : BaseService<Profile, ProfileDto>, IProfileService
    {

        public ProfileService(AutoMapper.IMapper mapper,
                              IValidator<SwanSong.Domain.Model.Profile.Profile> validator,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork,
                              IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<ProfileDto> GetAsync(int id)
        {
            return _mapper.Map<ProfileDto>(await _unitOfWork.Accounts.ByIdAsync(id));
        }

        public async Task<ProfileDto> UpdateAsync(int id, ProfileDto profileDto)
        {   
            Profile profile = _mapper.Map<Profile>(profileDto);
            profile.Id = id;

            ValidationResult result = await BeforeSaveAsync(profile);
            if (!result.IsValid)
                return GetDto(profile, result.Errors, false);
             
            Account account = await UpdateAccountAsync(profile.Id, profileDto); 

            return GetDto(profile, await AfterSaveAsync(profile, null), true);
        }

        public async Task<Account> UpdateAccountAsync(int id, ProfileDto profileDto)
        {
            Account account = await GetAccountAsync(id);
            account = _mapper.Map<ProfileDto, Account>(profileDto, account);

            _unitOfWork.Accounts.Update(account);
            await _unitOfWork.Complete();

            return account;
        } 

        private async Task<Account> GetAccountAsync(int id)
        {
            var account = await _unitOfWork.Accounts.ByIdAsync(id);
            if (account == null) throw new KeyNotFoundException(ConstantMessages.ProfileNotFound);
            return account;
        } 
    }
}
