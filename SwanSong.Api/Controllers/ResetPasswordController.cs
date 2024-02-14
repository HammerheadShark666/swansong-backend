using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api/forgot-password")]
public class ResetPasswordController : Controller
{
    private readonly ILogger<ResetPasswordController> _logger;
    private readonly IResetPasswordService _resetPasswordService;

    public ResetPasswordController(IResetPasswordService resetPasswordService, ILogger<ResetPasswordController> logger)
    { 
        _resetPasswordService = resetPasswordService;
        _logger = logger;
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
    public async Task<IActionResult> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new { message = GetMessages() });
        }                

        return Ok(await _resetPasswordService.ResetPasswordAsync(resetPasswordRequest));
    }

    private string GetMessages()
    {
        return string.Join("; ", ModelState.Values
                                    .SelectMany(x => x.Errors)
                                    .Select(x => x.ErrorMessage));
    }
}