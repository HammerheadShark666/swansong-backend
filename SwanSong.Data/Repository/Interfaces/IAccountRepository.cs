using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IAccountRepository : IBaseRepository<Account>
    {  
        Task<Account> GetAsync(string email);
        Task<Account> GetByResetTokenAsync(string resetToken);
        Task<Account> GetByVerificationTokenAsync(string verificationToken);
        Task<Account> GetByRefreshTokenAsync(string token);
        Task<bool> AccountExistsAsync(string email);
        Task<bool> AccountExistsAsync(string email, int id);
        Task<bool> AnyAccountExistAsync();
        Task<bool> ValidResetTokenAsync(string token); 
    }
}
