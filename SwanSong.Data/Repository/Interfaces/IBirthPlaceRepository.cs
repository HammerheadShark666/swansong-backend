using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IBirthPlaceRepository
{
    Task<bool> ExistsAsync(int ignoreId, string name);
    Task<bool> ExistsAsync(string name);
    Task<IEnumerable<BirthPlace>> AllAsync();
    Task AddAsync(BirthPlace birthPlace);
    void Update(BirthPlace birthPlace);
    void Delete(BirthPlace birthPlace);
    Task<BirthPlace> ByIdAsync(int id);
}