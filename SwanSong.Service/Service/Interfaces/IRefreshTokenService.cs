using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRefreshTokenService
{
    void RemoveExpiredRefreshTokens(int accountId);
    Task AddRefreshToken(RefreshToken refreshToken);
    RefreshToken GenerateRefreshToken(string ipAddress, Account account);
    Task<RefreshToken> GetRefreshTokenAsync(string token);
}