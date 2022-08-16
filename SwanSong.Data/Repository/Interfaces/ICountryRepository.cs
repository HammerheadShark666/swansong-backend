using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        Task<bool> ExistsAsync(int ignoreId, string name);
        Task<bool> ExistsAsync(string name);
        Task<Country> GetAsync(string name);         
    }
}
