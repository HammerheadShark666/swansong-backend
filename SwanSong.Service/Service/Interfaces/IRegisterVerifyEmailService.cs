using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRegisterVerifyEmailService
{
    Task<RegisterVerifyEmailActionResponse> VerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest);
}