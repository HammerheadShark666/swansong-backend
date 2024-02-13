using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IAlbumSongRepository
{
    Task<IEnumerable<AlbumSong>> GetAlbumSongsAsync(long albumId); 
    Task<bool> ExistsAsync(long? albumId, string title);
    Task<bool> ExistsAsync(long id, long? albumId, string title);
    Task<bool> TrackPositionExistsAsync(long albumId, long songId, int? side, int? order);
    Task AddAsync(AlbumSong albumSong);
    void Update(AlbumSong albumSong);
    void Delete(AlbumSong albumSong);
    Task<AlbumSong> ByIdAsync(long id);
}