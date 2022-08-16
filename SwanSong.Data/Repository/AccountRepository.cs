using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(SwanSongContext context) : base(context) { }
         
        public async Task<Account> GetAsync(string email)
        {
            return await _context.Accounts
                                   .Where(a => a.Email.Equals(email))
                                   .FirstOrDefaultAsync();
        }

        public async Task<Account> GetByResetTokenAsync(string resetToken)
        { 
            return await _context.Accounts.SingleOrDefaultAsync(u => u.ResetToken.Equals(resetToken));
        }

        public async Task<Account> GetByVerificationTokenAsync(string verificationToken)
        {
            return await _context.Accounts.SingleOrDefaultAsync(u => u.VerificationToken.Equals(verificationToken));
        }

        public async Task<Account> GetByRefreshTokenAsync(string token)
        {
            return await _context.Accounts.Where(p => p.RefreshTokens.Any(c => c.Token.Equals(token))).FirstOrDefaultAsync();
        }

        public async Task<bool> AccountExistsAsync(string email)
        {
            return await _context.Accounts.AnyAsync(x => x.Email.Equals(email));
        }

        public async Task<bool> AccountExistsAsync(string email, int id)
        {
            return await _context.Accounts.AnyAsync(x => x.Email.Equals(email) && x.Id != id);
        }

        public async Task<bool> AnyAccountExistAsync()
        {
            return await _context.Accounts.AnyAsync();
        }

        public async Task<bool> ValidResetTokenAsync(string token)
        {
            return await _context.Accounts.AnyAsync(x => x.ResetToken.Equals(token) && x.ResetTokenExpires > DateTime.Now);
        }
    }
}