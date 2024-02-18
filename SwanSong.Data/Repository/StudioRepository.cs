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

    public async Task<Studio> AddAsync(Studio studio)
    {
        await _context.Studios.AddAsync(studio);
        await _context.SaveChangesAsync();

        return studio;
    }

    public async Task<Studio> UpdateAsync(Studio studio)
    {
        var existingStudio = await _context.Studios.FirstOrDefaultAsync(p => p.Id == studio.Id);
        if (existingStudio != null)
        {
            existingStudio.Name = studio.Name;
        } 

        await _context.SaveChangesAsync();

        return existingStudio;
    }

    public async Task<int> DeleteAsync(int id)
    {
        var existingStudio = await _context.Studios.FirstOrDefaultAsync(p => p.Id == id);
        if (existingStudio is null) return 0;

        _context.Studios.Remove(existingStudio);

        await _context.SaveChangesAsync();

        return id; 
    }

    public async Task<List<Studio>> AllAsync()
    {
        return await _context.Studios.ToListAsync();
    }

    public async Task<Studio> ByIdAsync(int id)
    {
        return await _context.Studios.FindAsync(id);
    } 
}