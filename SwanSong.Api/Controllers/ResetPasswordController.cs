using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Linq;
using SwanSong.Domain.Dto;
using SwanSong.Helper;

namespace SwanSong.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api/forgot-password")]
    public class ResetPasswordController : BaseController<Account>
    {        
        private readonly IResetPasswordService _resetPasswordService;

        public ResetPasswordController(IResetPasswordService resetPasswordService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        { 
            _resetPasswordService = resetPasswordService; 
        }

        [HttpPost("")]
        public async Task<IActionResult> ForgotPasswordAsync(ForgotPasswordRequest model)
        {
            await _resetPasswordService.ForgotPasswordAsync(model);
            return Ok(new { message = ConstantMessages.PasswordResetEmailInstruction });
        }

        [HttpPost("validate-reset-token")]
        public async Task<IActionResult> ValidateResetTokenAsync(ValidateResetTokenRequest model)
        {
            await _resetPasswordService.ValidateResetTokenAsync(model);
            return Ok(new { message = ConstantMessages.TokenValid });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
        {
            if (ModelState.IsValid)
            { 
                resetPasswordDto = await _resetPasswordService.ResetPasswordAsync(resetPasswordDto);
                return resetPasswordDto.IsValid ? Ok(resetPasswordDto) : BadRequest(resetPasswordDto.Messages);
            }
            else
            {
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));

                return BadRequest(new { message = messages });
            }
            
        }
    }
}