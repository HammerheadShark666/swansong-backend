using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/artists")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ArtistController : BaseController<ArtistDto>
    {
        private readonly ILogger<AlbumsController> _logger;      
        private readonly IArtistService _artistService; 

        public ArtistController(ILogger<AlbumsController> logger, IHttpContextAccessor httpContextAccessor, IArtistService artistService) : base(httpContextAccessor)
        {
            _logger = logger; 
            _artistService = artistService; 
        }

        [HttpGet("lookups")]
        public async Task<ActionResult<List<ArtistLookupDto>>> GetAllAsync()
        {
            return Ok(await _artistService.GetLookupsAsync());
        } 

        [HttpGet("random")]
        public async Task<ActionResult<List<ArtistReadOnlyDto>>> GetRandomAsync()
        { 
            return Ok(await _artistService.GetRandomAsync(10));
        } 

        [HttpGet("")]
        public async Task<ActionResult<List<ArtistReadOnlyDto>>> GetAllAsync([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _artistService.GetAllAsync(validFilter);
            var totalRecords = await _artistService.CountAsync();

            return Ok(PagingHelper.CreatePagedReponse<ArtistReadOnlyDto>(pagedData, validFilter, totalRecords));
        }
 
        [HttpGet("search/{criteria}")]
        public async Task<ActionResult<List<ArtistReadOnlyDto>>> SearchAsync(string criteria)
        {
            return Ok(await _artistService.SearchByNameAsync(criteria));            
        } 
       
        [HttpGet("search-by-letter/{letter}")]
        public async Task<ActionResult<List<ArtistReadOnlyDto>>> SearchByLetterAsync(string letter)
        {
            return Ok(await _artistService.SearchByAlphaNumericAsync(letter));
        }
 
        [HttpGet("artist/{id}")]
        public async Task<ActionResult<ArtistDto>> GetArtistAsync(long id)
        {
            ArtistDto artistDto = await _artistService.GetAsync(id);
            return ActionResponse(artistDto);
        } 
    
        [HttpPost("artist/save")]
        public async Task<ActionResult<ArtistDto>> SaveAsync([FromBody] ArtistDto artistDto)
        {
            artistDto = await _artistService.SaveAsync(artistDto);
            return artistDto.IsValid ? Ok(artistDto) : BadRequest(artistDto.Messages);

        }

        [HttpDelete("artist/{id}")]
        public async Task<ActionResult<ArtistDto>> DeleteAsync(long id)
        {
            var artistDto = await _artistService.DeleteAsync(id);
            return artistDto.IsValid ? Ok(artistDto) : BadRequest(artistDto.Messages);
        }


        [Consumes("multipart/form-data")]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [HttpPost("artist/upload-photo/{id}")]
        public async Task<IActionResult> SavePhotoAsync(long id)
        {
            if (Request.Form.Files.Count > 0)
            {
                string fileName = await _artistService.UpdateArtistPhotoAsync(id, Request.Form.Files[0]);
                return Ok(fileName);
            }
            else
            {
                return BadRequest(ConstantMessages.NoFileToSave);
            }
        }

    }
}
