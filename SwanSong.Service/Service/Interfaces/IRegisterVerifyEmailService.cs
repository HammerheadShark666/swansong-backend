using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRegisterVerifyEmailService
{
    Task<RegisterVerifyEmailActionResponse> VerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest);
}