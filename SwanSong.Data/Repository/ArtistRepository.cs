using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(SwanSongContext context) : base(context) {}

        public async Task<List<Artist>> GetAllAsync(int pageNumber, int pageSize)
        {
            return await _context.Artists
                                 .OrderBy(a => a.Name)
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync(); 
        }

        public async Task<List<Artist>> GetRandomAsync(int numberOfArtists)
        {
            return await _context.Artists.OrderByDescending(x => Guid.NewGuid()).Take(numberOfArtists).ToListAsync();
        }

        public async Task<long> CountAsync()
        {
            return await _context.Artists.CountAsync();
        }

        public async Task<Artist> GetAsync(string name)
        {
            return await _context.Artists.FirstOrDefaultAsync(a => a.Name.Equals(name)); 
        }

        public async Task<Artist> GetWithMembersAsync(long id)
        {
            return await _context.Artists.Include(a => a.Members).FirstOrDefaultAsync(a => a.Id.Equals(id));
        }

        public async Task<IEnumerable<Artist>> SearchByNameAsync(string criteria)
        {
            return await (from artist in _context.Artists
                          where artist.Name.ToUpper().Contains(criteria.ToUpper())
                          select artist).ToListAsync();
        }

        public async Task<IEnumerable<Artist>> SearchByAlphaNumericAsync(string alphanumeric)
        {
            return await (from artist in _context.Artists
                          where artist.Name.ToUpper().Substring(0, 1).Equals(alphanumeric.ToUpper())
                          select artist).ToListAsync();
        }
               
        public async Task<Artist> GetAsync(long id)
        {
            return await _context.Artists
                                    .Include(e => e.Country)
                                    .Where(a => a.Id.Equals(id))
                                    .FirstOrDefaultAsync();
        }

        public async Task<Artist> GetAsync(long id, string name)
        {
            return await _context.Artists
                                   .Where(a => a.Name.Equals(name)
                                        && !a.Id.Equals(id))
                                   .FirstOrDefaultAsync();
        }

        public async Task<Artist> UpdateArtistPhotoAsync(long id, string filename)
        {
            Artist artist = await GetAsync(id); 

            artist.Photo = filename;
            _context.SaveChanges();

            return artist;
        }

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.Artists
                                    .Where(a => a.Name.Equals(name)).AnyAsync();
        }

        public async Task<bool> ExistsAsync(long ignoreId, string name)
        {
            return await _context.Artists
                                   .Where(a => a.Name.Equals(name)
                                        && !a.Id.Equals(ignoreId))
                                   .AnyAsync();
        }
    }
}