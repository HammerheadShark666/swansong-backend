using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IBirthPlaceRepository : IBaseRepository<BirthPlace>
    {
        Task<bool> ExistsAsync(int ignoreId, string name, int? countryId);        
        Task<bool> ExistsAsync(string name, int? countryId);
        Task<BirthPlace> GetAsync(string name);
    }
}
