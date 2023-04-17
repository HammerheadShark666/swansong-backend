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
    [Route("api/albums")] 
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)] 
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public class AlbumsController : BaseController<AlbumDto>
    {
        private readonly ILogger<AlbumsController> _logger;
        private readonly IAlbumService _albumService;  

        public AlbumsController(ILogger<AlbumsController> logger, IAlbumService albumService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _logger = logger;
            _albumService = albumService; 
        }
         
        [HttpGet("")]
        public async Task<ActionResult<List<AlbumReadOnlyDto>>> GetAllAsync([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _albumService.GetAllAsync(validFilter);
            var totalRecords = await _albumService.CountAsync();

            return Ok(PagingHelper.CreatePagedReponse<AlbumReadOnlyDto>(pagedData, validFilter, totalRecords));
        }

        [HttpGet("random")]
        public async Task<ActionResult<List<AlbumReadOnlyDto>>> GetRandomAsync()
        {
            return Ok(await _albumService.GetRandomAsync(10));
        }         
        
        [HttpGet("search/{criteria}")] 
        public async Task<ActionResult<List<AlbumReadOnlyDto>>> SearchAsync(string criteria) 
        {
            return Ok(await _albumService.SearchByNameAsync(criteria));                        
        }
              
        [HttpGet("search-by-letter/{letter}")] 
        public async Task<ActionResult<List<AlbumReadOnlyDto>>> SearchByLetterAsync(string letter)
        {
            return Ok(await _albumService.SearchByLetterAsync(letter));
        }

        [HttpGet("album/{id}")]
        public async Task<ActionResult<AlbumDto>> GetAlbumAsync(long id)
        {
            AlbumDto albumDto = await _albumService.GetAsync(id);
            return ActionResponse(albumDto);
        }

        [HttpGet("artist/{id}")]
        public async Task<ActionResult<List<AlbumReadOnlyDto>>> GetAlbumsForArtistAsync(long id)
        {
            return Ok(await _albumService.GetAlbumsForArtistAsync(id)); 
        }

        [HttpPost("album/save")] 
        public async Task<ActionResult<AlbumDto>> SaveAsync([FromBody] AlbumDto albumDto)
        {
            albumDto = await _albumService.SaveAsync(albumDto);
            return albumDto.IsValid ? Ok(albumDto) : BadRequest(albumDto.Messages);
        }

        [HttpDelete("album/{id}")]
        public async Task<ActionResult<AlbumDto>> DeleteAsync(long id)
        {
            var albumDto = await _albumService.DeleteAsync(id);
            return albumDto.IsValid ? Ok(albumDto) : BadRequest(albumDto.Messages);
        }

        [HttpPost("album/upload-photo/{id}")]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveAlbumPhotoAsync(long id)
        {
            if (Request.Form.Files.Count > 0)
            {
                string fileName = await _albumService.UpdateAlbumPhotoAsync(id, Request.Form.Files[0]); 
                return Ok(fileName);
            }
            else
            {
                return BadRequest(ConstantMessages.NoFileToSave);
            }
        }

        [HttpGet("random2")]
        public async Task<ActionResult<List<AlbumReadOnlyDto>>> GetRandom2Async()
        {
            return Ok(await _albumService.GetRandomAsync(10));
        }
    }
}
