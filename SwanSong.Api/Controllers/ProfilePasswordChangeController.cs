using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Profile;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api/profile/password-change")]
    public class ProfilePasswordChangeController : BaseController<ProfilePasswordChange>
    {
        private readonly IProfilePasswordChangeService _profilePasswordChangeService;
        private readonly IMapper _mapper;

        public ProfilePasswordChangeController(IProfilePasswordChangeService profilePasswordChangeService, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _profilePasswordChangeService = profilePasswordChangeService;
            _mapper = mapper;
        }
         

        [Authorize]
        [HttpPost("")]
        public async Task<ActionResult<ProfilePasswordChangeDto>> UpdatePasswordAsync(ProfilePasswordChangeDto profilePasswordChangeDto)
        {
            profilePasswordChangeDto.Id = LoggedInAccount.Id;
            profilePasswordChangeDto.Email = LoggedInAccount.Email;
            profilePasswordChangeDto = await _profilePasswordChangeService.UpdatePasswordAsync(profilePasswordChangeDto);
            return profilePasswordChangeDto.IsValid ? Ok(profilePasswordChangeDto) : BadRequest(profilePasswordChangeDto.Messages);
        }
    }
}
