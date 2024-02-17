using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class RefreshTokenRepository : IRefreshTokenRepository
{
    private readonly SwanSongContext _context;

    public RefreshTokenRepository(SwanSongContext context)
    {
        _context = context;
    }    

    public async Task<bool> ExistsAsync(string token)
    {
        return await _context.RefreshTokens.AnyAsync(a => a.Token.Equals(token));
    }
     
    public async Task AddAsync(RefreshToken refreshToken)
    {
        await _context.RefreshTokens.AddAsync(refreshToken);
    }

    public void Update(RefreshToken refreshToken)
    {
        _context.RefreshTokens.Update(refreshToken);
    }

    public void Delete(RefreshToken refreshToken)
    {
        _context.RefreshTokens.Remove(refreshToken);
    }

    public async Task<RefreshToken> ByTokenAsync(string token)
    {
        return await _context.RefreshTokens
                             .Include(a => a.Account)
                             .Where(x => x.Token.Equals(token))
                             .SingleOrDefaultAsync();
    }

    public async Task<List<RefreshToken>> ByIdAsync(int accountId)
    {
        return await _context.RefreshTokens.Where(a => a.Account.Id.Equals(accountId)).ToListAsync();
    }

    public void RemoveExpired(int expireDays, int accountId)
    {  
        var refreshTokens = _context.RefreshTokens.Where(a => a.Account.Id.Equals(accountId) 
                                                            && DateTime.Now >= a.Expires
                                                                && a.Created.AddDays(expireDays) <= DateTime.Now).ToList();

        _context.RefreshTokens.RemoveRange(refreshTokens);
    }
}