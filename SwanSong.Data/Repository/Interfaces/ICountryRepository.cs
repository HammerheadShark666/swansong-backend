using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface ICountryRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name); 
    Task<IEnumerable<Country>> AllAsync();
    Task AddAsync(Country country);
    void Update(Country country);
    void Delete(Country country);
    Task<Country> ByIdAsync(int id);
}