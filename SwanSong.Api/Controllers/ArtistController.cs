using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Filter;
using SwanSong.Service;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/artists")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class ArtistController : Controller
{
    private readonly ILogger<AlbumsController> _logger;      
    private readonly IArtistService _artistService; 

    public ArtistController(ILogger<AlbumsController> logger, IArtistService artistService)
    {
        _logger = logger; 
        _artistService = artistService; 
    }

    [HttpGet("lookups")]
    public async Task<ActionResult<List<ArtistLookUpResponse>>> GetAllAsync()
    {
        return Ok(await _artistService.GetLookupsAsync());
    } 

    [HttpGet("random")]
    public async Task<ActionResult<List<ArtistResponse>>> GetRandomAsync()
    { 
        return Ok(await _artistService.GetRandomAsync(10));
    } 

    [HttpGet("")]
    public async Task<ActionResult<List<ArtistResponse>>> GetAllAsync([FromQuery] PaginationFilter filter)
    {
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var pagedData = await _artistService.GetAllAsync(validFilter);
        var totalRecords = await _artistService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<ArtistResponse>(pagedData, validFilter, totalRecords));
    }

    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<ArtistResponse>>> SearchAsync(string criteria)
    {
        return Ok(await _artistService.SearchByNameAsync(criteria));            
    } 
   
    [HttpGet("search-by-letter/{letter}")]
    public async Task<ActionResult<List<ArtistResponse>>> SearchByLetterAsync(string letter)
    {
        return Ok(await _artistService.SearchByAlphaNumericAsync(letter));
    }

    [HttpGet("artist/{id}")]
    public async Task<ActionResult<ArtistResponse>> GetArtistAsync(long id)
    {  
        return Ok(await _artistService.GetAsync(id));
    } 

    [HttpPost("artist/add")]
    public async Task<ActionResult<ArtistActionResponse>> AddAsync([FromBody] ArtistAddRequest artistAddRequest)
    {         
         return Ok(await _artistService.AddAsync(artistAddRequest));         
    }

    [HttpPost("artist/update")]
    public async Task<ActionResult<ArtistActionResponse>> UpdateAsync([FromBody] ArtistUpdateRequest artistUpdateRequest)
    {         
         return Ok(await _artistService.UpdateAsync(artistUpdateRequest));         
    }


    [HttpDelete("artist/{id}")]
    public async Task<ActionResult<ArtistResponse>> DeleteAsync(long id)
    {         
         return Ok(await _artistService.DeleteAsync(id));         
    }

    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [HttpPost("artist/upload-photo/{id}")]
    public async Task<IActionResult> SavePhotoAsync(long id)
    {
        return Ok(await _artistService.UpdateArtistPhotoAsync(id, Request.Form.Files[0])); 
    }
}