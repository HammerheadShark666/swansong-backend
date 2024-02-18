using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IBirthPlaceRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name);
    Task<List<BirthPlace>> AllAsync();
    Task<BirthPlace> AddAsync(BirthPlace birthPlace);
    Task<BirthPlace> UpdateAsync(BirthPlace birthPlace);
    Task<int> DeleteAsync(int id);
    Task<BirthPlace> ByIdAsync(int id);
}