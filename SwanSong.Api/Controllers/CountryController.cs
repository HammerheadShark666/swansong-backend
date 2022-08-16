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
    [Route("api/countries")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class CountryController : BaseController<CountryDto>
    {
        private readonly ILogger<CountryController> _logger;      
        private readonly ICountryService _countryService;

        public CountryController(ILogger<CountryController> logger, IHttpContextAccessor httpContextAccessor, ICountryService countryService) : base(httpContextAccessor)
        {
            _logger = logger;
            _countryService = countryService; 
        }

        [HttpGet("")]
        public async Task<ActionResult<List<CountryDto>>> GetAllAsync()
        {
            var countrys = await _countryService.GetAllAsync();
            return countrys.Count == 0 ? NotFound() : Ok(countrys);
        }

        [Authorize] 
        [HttpPost("country/save")]
        public async Task<ActionResult<CountryDto>> SaveAsync([FromBody] CountryDto country)
        {
            var countryDto = await _countryService.SaveAsync(country);
            return countryDto.IsValid ? Ok(countryDto) : BadRequest(countryDto.Messages);
        }

        [Authorize] 
        [HttpDelete("country/{id}")]
        public async Task<ActionResult<CountryDto>> DeleteAsync(int id)
        {
            var countryDto = await _countryService.DeleteAsync(id);
            return countryDto.IsValid ? Ok(countryDto) : BadRequest(countryDto.Messages);  
        }
    }
}
