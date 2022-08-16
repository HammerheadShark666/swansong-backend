using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/album/songs")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class AlbumSongController : BaseController<AlbumSongDto>
    {
        private readonly ILogger<AlbumSongController> _logger;
        private readonly IAlbumSongService _albumSongService; 

        public AlbumSongController(ILogger<AlbumSongController> logger, IAlbumSongService albumSongService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _logger = logger;
            _albumSongService = albumSongService; 
        } 
         
        [HttpGet("{albumId}")]
        public async Task<ActionResult<List<AlbumSongDto>>> SearchAsync(long albumId)
        {
            return Ok(await _albumSongService.GetAlbumSongsAsync(albumId));            
        } 

        [HttpPost("save")]
        public async Task<ActionResult<AlbumSongDto>> SaveAsync([FromBody] AlbumSongDto song)
        {
            if (song == null)
                return BadRequest(ConstantMessages.AlbumSongNotSent);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);            

            AlbumSongDto albumSongDto = await _albumSongService.SaveAsync(song);
            return albumSongDto.IsValid ? Ok(albumSongDto) : BadRequest(albumSongDto.Messages);
        }

        [HttpDelete("song/{id}")]
        public async Task<ActionResult<AlbumSongDto>> DeleteAlbumSongAsync(long id)
        {
            AlbumSongDto albumSongDto = await _albumSongService.DeleteAsync(id);
            return albumSongDto.IsValid ? Ok(albumSongDto) : BadRequest(albumSongDto.Messages);
        }
    }
}
