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
    [Route("api/record-labels")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class RecordLabelController : BaseController<RecordLabelDto>
    {
        private readonly ILogger<RecordLabelController> _logger;      
        private readonly IRecordLabelService _recordLabelService;

        public RecordLabelController(ILogger<RecordLabelController> logger, IHttpContextAccessor httpContextAccessor, IRecordLabelService recordLabelService) : base(httpContextAccessor)
        {
            _logger = logger;
            _recordLabelService = recordLabelService; 
        }

        [HttpGet("")]
        public async Task<ActionResult<List<RecordLabelDto>>> GetAllAsync()
        {
            var recordLabels = await _recordLabelService.GetAllAsync();
            return recordLabels.Count == 0 ? NotFound() : Ok(recordLabels);
        }

        [Authorize] 
        [HttpPost("record-label/save")]
        public async Task<ActionResult<RecordLabelDto>> SaveAsync([FromBody] RecordLabelDto recordLabel)
        {
            var recordLabelDto = await _recordLabelService.SaveAsync(recordLabel);
            return recordLabelDto.IsValid ? Ok(recordLabelDto) : BadRequest(recordLabelDto.Messages);
        }

        [Authorize] 
        [HttpDelete("record-label/{id}")]
        public async Task<ActionResult<RecordLabelDto>> DeleteAsync(int id)
        {
            var recordLabelDto = await _recordLabelService.DeleteAsync(id);
            return recordLabelDto.IsValid ? Ok(recordLabelDto) : BadRequest(recordLabelDto.Messages);
        }
    }
}
