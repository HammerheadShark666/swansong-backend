using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Authentication;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IResetPasswordService
    {
        Task ForgotPasswordAsync(ForgotPasswordRequest model);
        Task ValidateResetTokenAsync(ValidateResetTokenRequest model);
        Task<ResetPasswordDto> ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
    }
}