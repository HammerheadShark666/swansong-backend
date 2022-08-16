using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api/register")]
    public class RegisterController : BaseController<Account>
    {        
        private readonly IRegisterService _registerService;
        private readonly IRegisterVerifyEmailService _registerVerifyEmailService;

        public RegisterController(IRegisterService registerService, IRegisterVerifyEmailService registerVerifyEmailService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        { 
            _registerService = registerService;
            _registerVerifyEmailService = registerVerifyEmailService;
        }

        [HttpPost("")]
        public async Task<IActionResult> RegisterAsync(RegisterDto registerDto)
        {            
            registerDto = await _registerService.RegisterAsync(registerDto);
            return registerDto.IsValid ? Ok(registerDto) : BadRequest(registerDto.Messages);                    
        }

        [HttpPost("verify-email")]
        public async Task<IActionResult> VerifyEmailAsync(RegisterVerifyEmailDto registerVerifyEmailDto)
        {
            registerVerifyEmailDto = await _registerVerifyEmailService.VerifyEmailAsync(registerVerifyEmailDto);
            return registerVerifyEmailDto.IsValid ? Ok(registerVerifyEmailDto) : BadRequest(registerVerifyEmailDto.Messages);
        } 
    }
}