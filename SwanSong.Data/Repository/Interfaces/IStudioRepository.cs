using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IStudioRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name);
    Task<List<Studio>> AllAsync();
    Task<Studio> AddAsync(Studio studio);
    Task<Studio> UpdateAsync(Studio studio);
    Task<int> DeleteAsync(int studioId);
    Task<Studio> ByIdAsync(int id); 
}