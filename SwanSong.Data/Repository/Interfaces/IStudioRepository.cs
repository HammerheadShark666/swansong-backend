using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IStudioRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name);
    Task<IEnumerable<Studio>> AllAsync();
    Task AddAsync(Studio studio);
    void Update(Studio studio);
    void Delete(Studio studio);
    Task<Studio> ByIdAsync(int id);
}