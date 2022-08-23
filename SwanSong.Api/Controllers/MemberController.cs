using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Settings;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [ApiVersion("1.0")]
    [Authorize]
    [Route("api/members")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class MembersController : BaseController<MemberDto>
    {
        private readonly ILogger<MembersController> _logger;      
        private readonly IMemberService _memberService;
        private readonly IOptions<AppSettings> _appSettings; 

        public MembersController(ILogger<MembersController> logger, IHttpContextAccessor httpContextAccessor, IMemberService memberService, IOptions<AppSettings> appSettings) : base(httpContextAccessor)
        {
            _logger = logger;
            _appSettings = appSettings;
            _memberService = memberService; 
        }

        [HttpGet("")]
        public async Task<ActionResult<List<MemberReadOnlyDto>>> GetAllAsync([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _memberService.GetAllAsync(validFilter);
            var totalRecords = await _memberService.CountAsync();

            return Ok(PagingHelper.CreatePagedReponse<MemberReadOnlyDto>(pagedData, validFilter, totalRecords));
        }

        [HttpGet("random")]
        public async Task<ActionResult<List<MemberReadOnlyDto>>> GetRandomAsync()
        {
            return Ok(await _memberService.GetRandomAsync(10));
        }
 
        [HttpGet("member/{id}")]
        public async Task<ActionResult<MemberDto>> GetMemberAsync(long id)
        {
            MemberDto memberDto = await _memberService.GetAsync(id);
            return ActionResponse(memberDto);
        }
 
        [HttpGet("search/{criteria}")]
        public async Task<ActionResult<List<MemberReadOnlyDto>>> SearchAsync(string criteria)
        {
            return Ok(await _memberService.SearchByNameAsync(criteria));
        }
 
        [HttpGet("search-by-letter/{letter}")]
        public async Task<ActionResult<List<MemberReadOnlyDto>>> SearchByLetterAsync(string letter)
        {
            return Ok(await _memberService.SearchByLetterAsync(letter));
        }

        [HttpGet("{artistId}")]
        public async Task<ActionResult<List<MemberDto>>> ArtistMembersAsync(long artistId)
        {
            return await _memberService.GetMembersByArtistAsync(artistId);
        }
 
        [HttpPost("member/save")]
        public async Task<ActionResult<MemberDto>> SaveAsync([FromBody] MemberDto memberDto)
        {
            memberDto = await _memberService.SaveAsync(memberDto);
            return memberDto.IsValid ? Ok(memberDto) : BadRequest(memberDto.Messages);
        }

        [HttpDelete("member/{id}")]
        public async Task<ActionResult<MemberDto>> DeleteAsync(long id)
        {
            var memberDto = await _memberService.DeleteAsync(id);
            return memberDto.IsValid ? Ok(memberDto) : BadRequest(memberDto.Messages);
        }

        [HttpPost("member/upload-photo/{id}")]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SavePhotoAsync(long id)
        {
            if (Request.Form.Files.Count > 0)
            {
                string fileName = await _memberService.UpdateMemberPhotoAsync(id, Request.Form.Files[0]);
                return Ok(fileName);
            }
            else
            {
                return BadRequest(ConstantMessages.NoFileToSave);
            }
        }

    }
}
