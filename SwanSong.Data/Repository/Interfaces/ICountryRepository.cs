using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface ICountryRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name); 
    Task<List<Country>> AllAsync();
    Task<Country> AddAsync(Country country);
    Task<Country> UpdateAsync(Country country);
    Task<int> DeleteAsync(int id);
    Task<Country> ByIdAsync(int id);
}