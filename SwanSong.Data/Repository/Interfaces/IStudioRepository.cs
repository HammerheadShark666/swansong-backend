using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IStudioRepository : IBaseRepository<Studio>
    {
        Task<bool> ExistsAsync(int ignoreId, string name);        
        Task<bool> ExistsAsync(string name);
        Task<Studio> GetAsync(string name);
    }
}
