using Asp.Versioning;
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
[Route("api/birth-places")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class BirthPlaceController : Controller
{
    private readonly ILogger<BirthPlaceController> _logger;      
    private readonly IBirthPlaceService _birthPlaceService;

    public BirthPlaceController(ILogger<BirthPlaceController> logger, IBirthPlaceService birthPlaceService)
    {
        _logger = logger;
        _birthPlaceService = birthPlaceService; 
    }

    [HttpGet("")]
    public async Task<ActionResult<List<BirthPlaceResponse>>> GetAllAsync()
    {
        var birthPlaces = await _birthPlaceService.GetAllAsync();
        return birthPlaces.Count == 0 ? NotFound() : Ok(birthPlaces);
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddBirthPlaceAsync([FromBody] BirthPlaceAddRequest birthPlaceAddRequest)
    {
        return Ok(await _birthPlaceService.AddAsync(birthPlaceAddRequest));        
    }

    [HttpPost("update")]
    public async Task<IActionResult> UpdateBirthPlaceAsync([FromBody] BirthPlaceUpdateRequest birthPlaceUpdateRequest)
    {
        return Ok(await _birthPlaceService.UpdateAsync(birthPlaceUpdateRequest));
    }
            
    [HttpDelete("birth-place/{id}")]
    public async Task<ActionResult<BirthPlaceActionResponse>> DeleteAsync(int id)
    {
        return Ok(await _birthPlaceService.DeleteAsync(id));         
    }
}