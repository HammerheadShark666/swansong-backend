using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class RecordLabelRepository : IRecordLabelRepository
{
    private readonly SwanSongContext _context;

    public RecordLabelRepository(SwanSongContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.RecordLabels.AnyAsync(a => a.Name.Equals(name));
    }

    public async Task<bool> ExistsAsync(int ignoreId, string name)
    {
        return await _context.RecordLabels.AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
    }

    public async Task<RecordLabel> AddAsync(RecordLabel recordLabel)
    {
        await _context.RecordLabels.AddAsync(recordLabel);
        await _context.SaveChangesAsync();

        return recordLabel;
    }

    public async Task<RecordLabel> UpdateAsync(RecordLabel recordLabel)
    {
        var existingRecordLabel = await _context.RecordLabels.FirstOrDefaultAsync(p => p.Id == recordLabel.Id);
        if (existingRecordLabel != null)
        {
            existingRecordLabel.Name = recordLabel.Name;
        }

        await _context.SaveChangesAsync();

        return existingRecordLabel;
    }

    public async Task<int> DeleteAsync(int id)
    {
        var existingRecordLabel = await _context.RecordLabels.FirstOrDefaultAsync(p => p.Id == id);
        if (existingRecordLabel is null) return 0;

        _context.RecordLabels.Remove(existingRecordLabel);

        await _context.SaveChangesAsync();

        return id;
    }

    public async Task<List<RecordLabel>> AllAsync()
    {
        return await _context.RecordLabels.ToListAsync();
    }

    public async Task<RecordLabel> ByIdAsync(int id)
    {
        return await _context.RecordLabels.FindAsync(id);
    }
}