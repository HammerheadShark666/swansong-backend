using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [ApiVersion("1.0")]
    [Authorize]
    [Route("api/studios")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class StudioController : BaseController<StudioDto>
    {
        private readonly ILogger<StudioController> _logger;      
        private readonly IStudioService _studioService;

        public StudioController(ILogger<StudioController> logger, IHttpContextAccessor httpContextAccessor, IStudioService studioService) : base(httpContextAccessor)
        {
            _logger = logger;
            _studioService = studioService; 
        }

        [HttpGet("")]
        public async Task<ActionResult<List<StudioReadOnlyDto>>> GetAllAsync()
        {
            return await _studioService.GetAllAsync(); 
        }

        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [HttpPost("studio/save")]
        public async Task<ActionResult<StudioDto>> SaveAsync([FromBody] StudioDto studio)
        {
            var studioDto = await _studioService.SaveAsync(studio);
            return studioDto.IsValid ? Ok(studioDto) : BadRequest(studioDto.Messages);
        }

        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [HttpDelete("studio/{id}")]
        public async Task<ActionResult<StudioDto>> DeleteAsync(int id)
        {
            var studioDto = await _studioService.DeleteAsync(id);
            return studioDto.IsValid ? Ok(studioDto) : BadRequest(studioDto.Messages);
        }
    }
}