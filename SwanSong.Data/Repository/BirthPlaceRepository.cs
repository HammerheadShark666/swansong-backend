using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class BirthPlaceRepository : IBirthPlaceRepository
{
    private readonly SwanSongContext _context;

    public BirthPlaceRepository(SwanSongContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.BirthPlaces.AnyAsync(a => a.Name.Equals(name));
    }

    public async Task<bool> ExistsAsync(int ignoreId, string name)
    {
        return await _context.BirthPlaces.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
    }

    public async Task<BirthPlace> AddAsync(BirthPlace birthPlace)
    {
        await _context.BirthPlaces.AddAsync(birthPlace);
        await _context.SaveChangesAsync();

        return birthPlace;
    }

    public async Task<BirthPlace> UpdateAsync(BirthPlace birthPlace)
    {
        var existingBirthPlace = await _context.BirthPlaces.FirstOrDefaultAsync(p => p.Id == birthPlace.Id);
        if (existingBirthPlace != null)
        {
            existingBirthPlace.Name = birthPlace.Name;
        }

        await _context.SaveChangesAsync();

        return existingBirthPlace;
    }

    public async Task<int> DeleteAsync(int id)
    {
        var existingBirthPlace = await _context.BirthPlaces.FirstOrDefaultAsync(p => p.Id == id);
        if (existingBirthPlace is null) return 0;

        _context.BirthPlaces.Remove(existingBirthPlace);

        await _context.SaveChangesAsync();

        return id;
    }

    public async Task<List<BirthPlace>> AllAsync()
    {
        return await _context.BirthPlaces.ToListAsync();
    }

    public async Task<BirthPlace> ByIdAsync(int id)
    {
        return await _context.BirthPlaces.FindAsync(id);
    }
}