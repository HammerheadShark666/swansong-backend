using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController] 
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api")]
public class AuthenticateController : Controller
{
    private readonly ILogger<ProfileController> _logger;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IAuthenticateService _authenticateService;

    public AuthenticateController(IAuthenticateService authenticateService, IHttpContextAccessor httpContextAccessor, ILogger<ProfileController> logger)
    {
        _httpContextAccessor = httpContextAccessor;
        _authenticateService = authenticateService;
        _logger = logger;
    } 

    [HttpPost("login")]
    public async Task<ActionResult<LoginActionResponse>> LoginAsync(LoginRequest loginRequest)
    { 
        return Ok(await _authenticateService.AuthenticateAsync(loginRequest, AuthenticationHelper.IpAddress(Request, HttpContext)));
    } 

    [HttpPost("refresh-token")]
    public async Task<ActionResult<JwtRefreshTokenActionResponse>> RefreshTokenAsync(JwtRefreshTokenRequest jwtRefreshTokenRequest)
    {
        return Ok(await _authenticateService.RefreshTokenAsync(jwtRefreshTokenRequest.RefreshToken, AuthenticationHelper.IpAddress(Request, HttpContext)));
    }

    private Account LoggedInAccount()
    {
        var context = _httpContextAccessor.HttpContext;
        return (Account)context.Items["Account"];
    }
}