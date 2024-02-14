using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/songs")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class SongController : Controller
{
    private readonly ILogger<AlbumSongController> _logger;
    private readonly ISongService _songService; 

    public SongController(ILogger<AlbumSongController> logger, ISongService songService)
    { 
        _logger = logger;
        _songService = songService; 
    }  

    [HttpDelete("song/{id}")]
    public async Task<ActionResult<AlbumSongActionResponse>> DeleteAsync(long id)
    {
        return Ok(await _songService.DeleteAsync(id));
    }
}