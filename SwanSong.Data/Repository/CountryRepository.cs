using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class CountryRepository : ICountryRepository
{
    private readonly SwanSongContext _context;

    public CountryRepository(SwanSongContext context)
    {
        _context = context;
    }    

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.Countries.AnyAsync(a => a.Name.Equals(name));
    }

    public async Task<bool> ExistsAsync(int ignoreId, string name)
    {
        return await _context.Countries.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
    }

    public async Task<Country> AddAsync(Country country)
    {
        await _context.Countries.AddAsync(country);
        await _context.SaveChangesAsync();

        return country; 
    }

    public async Task<Country> UpdateAsync(Country country)
    {
        var existingCountry = await _context.Countries.FirstOrDefaultAsync(p => p.Id == country.Id);
        if (existingCountry != null)
        {
            existingCountry.Name = country.Name;
        }

        await _context.SaveChangesAsync();

        return existingCountry; 
    }

    public async Task<int> DeleteAsync(int id)
    {
        var existingCountry = await _context.Countries.FirstOrDefaultAsync(p => p.Id == id);
        if (existingCountry is null) return 0;

        _context.Countries.Remove(existingCountry);

        await _context.SaveChangesAsync();

        return id; 
    }

    public async Task<List<Country>> AllAsync()
    {
        return await _context.Countries.ToListAsync();
    }

    public async Task<Country> ByIdAsync(int id)
    {
        return await _context.Countries.FindAsync(id);
    }
}