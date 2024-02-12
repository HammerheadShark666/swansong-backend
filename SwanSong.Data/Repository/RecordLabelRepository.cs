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

    public async Task AddAsync(RecordLabel recordLabel)
    {
        await _context.RecordLabels.AddAsync(recordLabel);
    }

    public void Update(RecordLabel recordLabel)
    {
        _context.RecordLabels.Update(recordLabel);
    }

    public void Delete(RecordLabel recordLabel)
    {
        _context.RecordLabels.Remove(recordLabel);
    }

    public async Task<IEnumerable<RecordLabel>> AllAsync()
    {
        return await _context.RecordLabels.ToListAsync();
    }

    public async Task<RecordLabel> ByIdAsync(int id)
    {
        return await _context.RecordLabels.FindAsync(id);
    }
}