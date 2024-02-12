using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IRecordLabelRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name);
    Task<IEnumerable<RecordLabel>> AllAsync();
    Task AddAsync(RecordLabel recordLabel);
    void Update(RecordLabel recordLabel);
    void Delete(RecordLabel recordLabel);
    Task<RecordLabel> ByIdAsync(int id); 
}