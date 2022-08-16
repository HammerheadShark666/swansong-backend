using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class StudioRepository : BaseRepository<Studio>, IStudioRepository
    {
        public StudioRepository(SwanSongContext context) : base(context) {}

        public async Task<Studio> GetAsync(string name)
        {
            return await _context.Studios.FirstOrDefaultAsync(a => a.Name.Equals(name)); 
        }                

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.Studios.AnyAsync(a => a.Name.Equals(name));
        }

        public async Task<bool> ExistsAsync(int ignoreId, string name)
        {
            return await _context.Studios.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
        }
    }
}