using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class ArtistRepository : IArtistRepository
{
    private readonly SwanSongContext _context;

    public ArtistRepository(SwanSongContext context)
    {
        _context = context;
    }

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

    public async Task AddAsync(Artist artist)
    {
        await _context.Artists.AddAsync(artist);
    }

    public void Update(Artist artist)
    {
        _context.Artists.Update(artist);
    }

    public void Delete(Artist artist)
    {
        _context.Artists.Remove(artist);
    }

    public async Task<IEnumerable<Artist>> AllAsync()
    {
        return await _context.Artists.ToListAsync();
    }

    public async Task<Artist> ByIdAsync(long id)
    {
        return await _context.Artists.FindAsync(id);
    }

    public async Task<Artist> ByIdWithMembersAsync(long id)
    {
        return await _context.Artists
                                .Include(e => e.Members)
                                .Where(a => a.Id.Equals(id))
                                .FirstOrDefaultAsync();  
    }
}