using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IRegisterVerifyEmailService
    {
        Task<RegisterVerifyEmailDto> VerifyEmailAsync(RegisterVerifyEmailDto registerVerifyEmailDto);
    }
}