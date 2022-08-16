using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/profile")]
    public class ProfileController : BaseController<ProfileDto>
    {
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public ProfileController(IProfileService profileService, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _profileService = profileService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpPost("update")]
        public async Task<ActionResult<ProfileDto>> UpdateAsync(ProfileDto profileDto)
        {
            profileDto = await _profileService.UpdateAsync(LoggedInAccount.Id, profileDto);
            return profileDto.IsValid ? Ok(profileDto) : BadRequest(profileDto.Messages); 
        }

        [Authorize]
        [HttpGet("")]
        public async Task<ActionResult<ProfileDto>> ProfileAsync()
        {
            ProfileDto profileDto = await _profileService.GetAsync(LoggedInAccount.Id);
            return ActionResponse(profileDto);
        }
    }
}
