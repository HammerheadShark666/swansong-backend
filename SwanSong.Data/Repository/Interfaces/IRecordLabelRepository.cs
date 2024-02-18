using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IRecordLabelRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name);
    Task<List<RecordLabel>> AllAsync();
    Task<RecordLabel> AddAsync(RecordLabel recordLabel);
    Task<RecordLabel> UpdateAsync(RecordLabel recordLabel);
    Task<int> DeleteAsync(int id);
    Task<RecordLabel> ByIdAsync(int id); 
}