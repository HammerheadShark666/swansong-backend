using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class SongRepository : BaseRepository<Song>, ISongRepository
    {
        public SongRepository(SwanSongContext context) : base(context) {}
        
        public async Task<Song> GetByIdAsync(long id)
        {
            return await _context.Songs.FirstOrDefaultAsync(a => a.Id.Equals(id));
        }

        public async Task<Song> GetAsync(string title)
        {
            return await _context.Songs.FirstOrDefaultAsync(a => a.Title.Equals(title)); 
        }                

        public async Task<bool> ExistsAsync(string title)
        {
            return await _context.Songs.AnyAsync(a => a.Title.Equals(title));
        }

        public async Task<bool> ExistsAsync(int ignoreId, string title)
        {
            return await _context.Songs.AnyAsync(a => a.Title.Equals(title) && !a.Id.Equals(ignoreId));
        }
    }
}