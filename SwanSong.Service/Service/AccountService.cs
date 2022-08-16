using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class AccountService : BaseService<Account, AccountDto>, IAccountService
    {        
        public AccountService(IMapper mapper,
                              IValidator<Account> validator,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork,
                              IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<AccountDto> SaveAsync(AccountDto accountDto)
        { 
            Account account = await GetAccountAsync(accountDto);

            ValidationResult result = await BeforeSaveAsync(account);
            if (!result.IsValid)
                return GetDto(account, result.Errors, false);

            account = await SaveAsync(account);

            return GetDto(account, await AfterSaveAsync(account, null), true);

        }

        private async Task<Account> GetAccountAsync(AccountDto accountDto)
        {
            Account currentAccount = accountDto.Id == 0 ? new() : await _unitOfWork.Accounts.ByIdAsync(accountDto.Id);
            return _mapper.Map<AccountDto, Account>(accountDto, currentAccount);
        }

        private async Task<Account> SaveAsync(Account account)
        {
            if (account.Id == 0)
                _unitOfWork.Accounts.Add(account);
            else
                _unitOfWork.Accounts.Update(account);

            await _unitOfWork.Complete();

            return account;
        }      
    }
}
