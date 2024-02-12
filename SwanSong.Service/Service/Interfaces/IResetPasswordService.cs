using SwanSong.Domain.Model.Authentication;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IResetPasswordService
{
    Task ForgotPasswordAsync(ForgotPasswordRequest model);
    Task ValidateResetTokenAsync(ValidateResetTokenRequest model);
    Task<ResetPasswordActionResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest);
}