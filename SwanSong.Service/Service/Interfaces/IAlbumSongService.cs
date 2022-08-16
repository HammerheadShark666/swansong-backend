using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IAlbumSongService
    {
        Task<List<AlbumSongDto>> GetAlbumSongsAsync(long albumId);
        Task<AlbumSongDto> GetAlbumSongAsync(long albumId, long songId);
        Task<AlbumSongDto> SaveAsync(AlbumSongDto albumSong);
        Task<AlbumSongDto> DeleteAsync(long id);
    }
}