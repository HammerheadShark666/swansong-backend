using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IAlbumSongRepository : IBaseRepository<AlbumSong>
    {
        Task<IEnumerable<AlbumSong>> GetAlbumSongsAsync(long albumId);
        Task<AlbumSong> GetAsync(long albumId, long songId);
        Task<AlbumSong> GetAsync(long id);
        Task<bool> ExistsAsync(long? albumId, string title);
        Task<bool> ExistsAsync(long id, long? albumId, string title);
        
    }
}
