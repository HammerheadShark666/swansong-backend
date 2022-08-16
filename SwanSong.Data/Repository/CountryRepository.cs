using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(SwanSongContext context) : base(context) {}
        
        public async Task<Country> GetAsync(string name)
        {
            return await _context.Countries.FirstOrDefaultAsync(a => a.Name.Equals(name)); 
        }                

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.Countries.AnyAsync(a => a.Name.Equals(name));
        }

        public async Task<bool> ExistsAsync(int ignoreId, string name)
        {
            return await _context.Countries.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
        }
    }
}