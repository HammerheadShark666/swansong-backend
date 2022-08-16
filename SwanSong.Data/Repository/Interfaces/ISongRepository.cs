using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface ISongRepository : IBaseRepository<Song>
    {
        Task<bool> ExistsAsync(int ignoreId, string title);
        Task<bool> ExistsAsync(string title);
        Task<Song> GetAsync(string title);
        Task<Song> GetByIdAsync(long id);
    }
}
