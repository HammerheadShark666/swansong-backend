using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class StudioRepository : IStudioRepository
{
    private readonly SwanSongContext _context;

    public StudioRepository(SwanSongContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.Studios.AnyAsync(a => a.Name.Equals(name));
    }

    public async Task<bool> ExistsAsync(int ignoreId, string name)
    {
        return await _context.Studios.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
    }

    public async Task AddAsync(Studio studio)
    {
        await _context.Studios.AddAsync(studio);
    }

    public void Update(Studio studio)
    {
        _context.Studios.Update(studio);
    }

    public void Delete(Studio studio)
    {
        _context.Studios.Remove(studio);
    }

    public async Task<IEnumerable<Studio>> AllAsync()
    {
        return await _context.Studios.ToListAsync();
    }

    public async Task<Studio> ByIdAsync(int id)
    {
        return await _context.Studios.FindAsync(id);
    }
}