using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class AlbumSongRepository : BaseRepository<AlbumSong>, IAlbumSongRepository
    {
        public AlbumSongRepository(SwanSongContext context) : base(context) {}

        public async Task<IEnumerable<AlbumSong>> GetAlbumSongsAsync(long albumId)
        {
            return await _context.AlbumSongs
                                    .Include(e => e.Song)
                                    .Where(e => e.AlbumId.Equals(albumId))
                                    .OrderBy(e => e.Order).ToListAsync();
        }

        public async Task<AlbumSong> GetAsync(long albumId, long songId)
        {
            var albumSong = await _context.AlbumSongs.FindAsync(albumId);

            var song = await _context.AlbumSongs
                                        .Include(e => e.Song)
                                        .Where(a => a.AlbumId.Equals(albumId)
                                            && a.Song.Id.Equals(songId))
                                        .FirstOrDefaultAsync();

            return song;
        }

        public async Task<AlbumSong> GetAsync(long id)
        {
            return await _context.AlbumSongs
                                    .Include(e => e.Song)
                                    .Where(e => e.Id.Equals(id))
                                    .FirstOrDefaultAsync();
        }

        public async Task<bool> ExistsAsync(long? albumId, string title)
        {
            return await _context.AlbumSongs
                                   .Where(a => a.Song.Title.ToUpper().Equals(title.ToUpper())
                                        && a.AlbumId.Equals(albumId))
                                   .AnyAsync();
        } 

        public async Task<bool> ExistsAsync(long id, long? albumId, string title)
        {
            return await _context.AlbumSongs
                                   .Where(a => a.Song.Title.ToUpper().Equals(title.ToUpper())
                                        && a.AlbumId.Equals(albumId)
                                            && !a.Id.Equals(id))
                                   .AnyAsync();
        }
    }
}