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

    public async Task AddAsync(BirthPlace birthPlace)
    {
        await _context.BirthPlaces.AddAsync(birthPlace);
    }

    public void Update(BirthPlace birthPlace)
    {
        _context.BirthPlaces.Update(birthPlace);
    }

    public void Delete(BirthPlace birthPlace)
    {
        _context.BirthPlaces.Remove(birthPlace);
    }

    public async Task<IEnumerable<BirthPlace>> AllAsync()
    {
        return await _context.BirthPlaces.ToListAsync();
    }

    public async Task<BirthPlace> ByIdAsync(int id)
    {
        return await _context.BirthPlaces.FindAsync(id);
    }
}