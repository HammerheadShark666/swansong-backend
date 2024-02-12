using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IAuthenticateService
{
    Task<LoginActionResponse> AuthenticateAsync(LoginRequest loginRequest, string ipAddress);
    Task<JwtRefreshTokenActionResponse> RefreshTokenAsync(string token, string ipAddress);
}