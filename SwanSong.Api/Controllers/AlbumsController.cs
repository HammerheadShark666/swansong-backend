using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

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
public class AlbumsController : Controller
{
    private readonly ILogger<AlbumsController> _logger;
    private readonly IAlbumService _albumService;  

    public AlbumsController(ILogger<AlbumsController> logger, IAlbumService albumService)
    {
        _logger = logger;
        _albumService = albumService; 
    }
     
    [HttpGet("")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetAllAsync([FromQuery] PaginationFilter filter)
    {
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var pagedData = await _albumService.GetAllAsync(validFilter);
        var totalRecords = await _albumService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<AlbumLookUpResponse>(pagedData, validFilter, totalRecords));
    }

    [HttpGet("random")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetRandomAsync()
    {
        return Ok(await _albumService.GetRandomAsync(10));
    }         
    
    [HttpGet("search/{criteria}")] 
    public async Task<ActionResult<List<AlbumLookUpResponse>>> SearchAsync(string criteria) 
    {
        return Ok(await _albumService.SearchByNameAsync(criteria));                        
    }
          
    [HttpGet("search-by-letter/{letter}")] 
    public async Task<ActionResult<List<AlbumLookUpResponse>>> SearchByLetterAsync(string letter)
    {
        return Ok(await _albumService.SearchByLetterAsync(letter));
    }

    [HttpGet("album/{id}")]
    public async Task<ActionResult<AlbumResponse>> GetAlbumAsync(long id)
    { 
        return Ok(await _albumService.GetAsync(id));
    }

    [HttpGet("artist/{id}")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetAlbumsForArtistAsync(long id)
    {
        return Ok(await _albumService.GetAlbumsForArtistAsync(id));
    }

    [HttpPost("album/add")]
    public async Task<ActionResult<AlbumActionResponse>> AddAsync([FromBody] AlbumAddRequest albumAddRequest)
    {
        return Ok(await _albumService.AddAsync(albumAddRequest));        
    }

    [HttpPost("album/update")]
    public async Task<ActionResult<AlbumActionResponse>> UpdateAsync([FromBody] AlbumUpdateRequest albumUpdateRequest)
    {
        return Ok(await _albumService.UpdateAsync(albumUpdateRequest)); 
    }


    [HttpDelete("album/{id}")]
    public async Task<ActionResult<AlbumActionResponse>> DeleteAsync(long id)
    {
        return Ok(await _albumService.DeleteAsync(id)); 
    }
 
    [HttpPost("album/upload-photo/{id}")]
    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SaveAlbumPhotoAsync(long id)
    {
        if (Request.Form.Files.Count > 0)
        {
            return Ok(await _albumService.UpdateAlbumPhotoAsync(id, Request.Form.Files[0]));
        }
        else
        {
            return BadRequest(ConstantMessages.NoFileToSave);
        }
    } 
}