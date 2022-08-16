using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IAuthenticateService
    {
        Task<LoginDto> AuthenticateAsync(LoginDto loginDto, string ipAddress);
        Task<JwtRefreshTokenDto> RefreshTokenAsync(string token, string ipAddress);
    }
}