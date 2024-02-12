using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IAccountRepository
{  
    Task<Account> GetAsync(string email);
    Task<Account> GetByResetTokenAsync(string resetToken);
    Task<Account> GetByVerificationTokenAsync(string verificationToken);
    Task<Account> GetByRefreshTokenAsync(string token);
    Task<bool> AccountExistsAsync(string email);
    Task<bool> AccountExistsAsync(string email, int id);
    Task<bool> AnyAccountExistAsync();
    Task<bool> ValidResetTokenAsync(string token);
    Task<Account> ByIdAsync(int id);
    void Add(Account account);
    void Update(Account account);
    void Delete(Account account);
}