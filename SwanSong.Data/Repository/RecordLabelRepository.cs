using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class RecordLabelRepository : BaseRepository<RecordLabel>, IRecordLabelRepository
    {
        public RecordLabelRepository(SwanSongContext context) : base(context) {}
        
        public async Task<RecordLabel> GetAsync(string name)
        {
            return await _context.RecordLabels.FirstOrDefaultAsync(a => a.Name.Equals(name)); 
        }

        public async Task<bool> RecordLabelHasAlbumsAsync(int id)
        {
            return await _context.RecordLabels
                                    .Include(e => e.Albums)
                                    .Where(a => a.Id.Equals(id))
                                    .CountAsync(e => e.Albums.Count > 0) > 0;
        }

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.RecordLabels.AnyAsync(a => a.Name.Equals(name));
        }

        public async Task<bool> ExistsAsync(int ignoreId, string name)
        {
            return await _context.RecordLabels.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
        }
    }
}