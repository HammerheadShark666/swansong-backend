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
[Route("api/countries")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class CountryController : Controller
{
    private readonly ILogger<CountryController> _logger;      
    private readonly ICountryService _countryService;

    public CountryController(ILogger<CountryController> logger, ICountryService countryService) 
    {
        _logger = logger;
        _countryService = countryService; 
    }

    [HttpGet("")]
    public async Task<ActionResult<List<CountryResponse>>> GetAllAsync()
    {
        var countrys = await _countryService.GetAllAsync();
        return countrys.Count == 0 ? NotFound() : Ok(countrys);
    }

    [HttpPost("country/add")]
    public async Task<IActionResult> AddCountryAsync([FromBody] CountryAddRequest countryAddRequest)
    {
        return Ok(await _countryService.AddAsync(countryAddRequest)); 
    }

    [HttpPost("country/update")]
    public async Task<IActionResult> UpdateCountryAsync([FromBody] CountryUpdateRequest countryUpdateRequest)
    {
        return Ok(await _countryService.UpdateAsync(countryUpdateRequest));
    }
            
    [HttpDelete("country/{id}")]
    public async Task<ActionResult<CountryActionResponse>> DeleteAsync(int id)
    {
        return Ok(await _countryService.DeleteAsync(id));
    }
}
