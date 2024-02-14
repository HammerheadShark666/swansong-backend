using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/album/songs")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class AlbumSongController : Controller
{
    private readonly ILogger<AlbumSongController> _logger;
    private readonly IAlbumSongService _albumSongService; 

    public AlbumSongController(ILogger<AlbumSongController> logger, IAlbumSongService albumSongService)
    { 
        _logger = logger;
        _albumSongService = albumSongService; 
    } 
     
    [HttpGet("{albumId}")]
    public async Task<ActionResult<List<AlbumSongResponse>>> SearchAsync(long albumId)
    {
        return Ok(await _albumSongService.GetAlbumSongsAsync(albumId));            
    }

    [HttpPost("song/add")]
    public async Task<ActionResult<AlbumSongActionResponse>> AddAsync([FromBody] AlbumSongAddRequest albumSongAddRequest)
    {         
         return Ok(await _albumSongService.AddAsync(albumSongAddRequest));
    }

    [HttpPost("song/update")]
    public async Task<ActionResult<AlbumSongActionResponse>> UpdateAsync([FromBody] AlbumSongUpdateRequest albumSongUpdateRequest)
    {
        return Ok(await _albumSongService.UpdateAsync(albumSongUpdateRequest));
    }

    [HttpDelete("song/{id}")]
    public async Task<ActionResult<AlbumSongActionResponse>> DeleteAsync(long id)
    {
        return Ok(await _albumSongService.DeleteAsync(id));        
    }
}