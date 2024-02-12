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

    public async Task AddAsync(Country country)
    {
        await _context.Countries.AddAsync(country);
    }

    public void Update(Country country)
    {
        _context.Countries.Update(country);
    }

    public void Delete(Country country)
    {
        _context.Countries.Remove(country);
    }

    public async Task<IEnumerable<Country>> AllAsync()
    {
        return await _context.Countries.ToListAsync();
    }

    public async Task<Country> ByIdAsync(int id)
    {
        return await _context.Countries.FindAsync(id);
    }
}