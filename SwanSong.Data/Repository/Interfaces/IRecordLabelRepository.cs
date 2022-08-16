using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IRecordLabelRepository : IBaseRepository<RecordLabel>
    {
        Task<bool> ExistsAsync(int ignoreId, string name);
        Task<bool> ExistsAsync(string name);
        Task<RecordLabel> GetAsync(string name);
        Task<bool> RecordLabelHasAlbumsAsync(int id);        
    }
}
