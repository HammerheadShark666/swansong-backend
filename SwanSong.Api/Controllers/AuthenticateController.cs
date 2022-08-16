using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController] 
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api")]
    public class AuthenticateController : BaseController<Account>
    { 
        private readonly IAuthenticateService _authenticateService;  

        public AuthenticateController(IAuthenticateService authenticateService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        { 
            _authenticateService = authenticateService; 
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginDto>> LoginAsync(LoginDto loginDto)
        {
            loginDto = await _authenticateService.AuthenticateAsync(loginDto, AuthenticationHelper.IpAddress(Request, HttpContext));
            return loginDto.IsValid ? Ok(loginDto) : BadRequest(loginDto.Messages);
        } 

        [HttpPost("refresh-token")]
        public async Task<ActionResult<JwtRefreshTokenDto>> RefreshTokenAsync(JwtRefreshTokenDto jwtRefreshTokenDto)
        {
            jwtRefreshTokenDto = await _authenticateService.RefreshTokenAsync(jwtRefreshTokenDto.RefreshToken, AuthenticationHelper.IpAddress(Request, HttpContext));
            return jwtRefreshTokenDto.IsValid ? Ok(jwtRefreshTokenDto) : BadRequest(jwtRefreshTokenDto.Messages);
        }
    }
}
