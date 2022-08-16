using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IAccountService
    {
        Task<AccountDto> SaveAsync(AccountDto accountDto); 
    }
}