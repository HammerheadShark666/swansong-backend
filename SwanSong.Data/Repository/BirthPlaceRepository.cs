using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class BirthPlaceRepository : BaseRepository<BirthPlace>, IBirthPlaceRepository
    {
        public BirthPlaceRepository(SwanSongContext context) : base(context) {}
       
        public async Task<BirthPlace> GetAsync(string name)
        {
            return await _context.BirthPlaces.FirstOrDefaultAsync(a => a.Name.Equals(name)); 
        }                

        public async Task<bool> ExistsAsync(string name, int? countryId)
        {
            return await _context.BirthPlaces.AnyAsync(a => a.Name.Equals(name) && a.CountryId.Equals(countryId));
        }

        public async Task<bool> ExistsAsync(int ignoreId, string name, int? countryId)
        {
            return await _context.BirthPlaces.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId) && a.CountryId.Equals(countryId));
        }
    }
}