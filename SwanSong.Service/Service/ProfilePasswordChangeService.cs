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
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service
{
    public class ProfilePasswordChangeService : BaseService<ProfilePasswordChange, ProfilePasswordChangeDto>, IProfilePasswordChangeService
    {

        public ProfilePasswordChangeService(AutoMapper.IMapper mapper,
                              IValidator<SwanSong.Domain.Model.Profile.ProfilePasswordChange> validator,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork,
                              IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }
        
        public async Task<ProfilePasswordChangeDto> UpdatePasswordAsync(ProfilePasswordChangeDto profilePasswordChangeDto)
        {
            ProfilePasswordChange profilePasswordChange = _mapper.Map<ProfilePasswordChange>(profilePasswordChangeDto);
             
            ValidationResult result = await BeforeSaveAsync(profilePasswordChange);
            if (!result.IsValid)
                return GetDto(profilePasswordChange, result.Errors, false);

            Account account = await UpdatePasswordAsync(profilePasswordChange.Id, profilePasswordChangeDto);

            return GetDto(profilePasswordChange, await AfterSaveAsync(profilePasswordChange, null), true); 
        }

        public async Task<Account> UpdatePasswordAsync(int id, ProfilePasswordChangeDto profilePasswordChangeDto)
        {
            Account account = await GetAccountAsync(id);
            account = _mapper.Map<ProfilePasswordChangeDto, Account>(profilePasswordChangeDto, account);
            account.PasswordHash = BC.HashPassword(profilePasswordChangeDto.Password);

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
