using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[Authorize]
[Route("api/studios")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class StudioController : Controller
{
    private readonly ILogger<StudioController> _logger;      
    private readonly IStudioService _studioService;

    public StudioController(ILogger<StudioController> logger, IStudioService studioService)
    {
        _logger = logger;
        _studioService = studioService;
    }

    [HttpGet("")]
    public async Task<ActionResult<List<StudioResponse>>> GetAllAsync()
    {
        var studios = await _studioService.GetAllAsync();
        return studios.Count == 0 ? NotFound() : Ok(studios);
    }

    [HttpPost("studio/add")]
    public async Task<IActionResult> AddStudioAsync([FromBody] StudioAddRequest studioAddRequest)
    {
        return Ok(await _studioService.AddAsync(studioAddRequest));
    }

    [HttpPost("studio/update")]
    public async Task<IActionResult> UpdateStudioAsync([FromBody] StudioUpdateRequest studioUpdateRequest)
    {
        return Ok(await _studioService.UpdateAsync(studioUpdateRequest));
    }

    [HttpDelete("studio/{id}")]
    public async Task<ActionResult<StudioResponse>> DeleteAsync(int id)
    {
        return Ok(await _studioService.DeleteAsync(id));
    }
}