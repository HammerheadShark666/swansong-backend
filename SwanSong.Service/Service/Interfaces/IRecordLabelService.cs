using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IRecordLabelService
    {
        Task<List<RecordLabelReadOnlyDto>> GetAllAsync();
        Task<RecordLabelDto> GetAsync(int id);
        Task<RecordLabelDto> SaveAsync(RecordLabelDto labelDto); 
        Task<RecordLabelDto> DeleteAsync(int id);
    }
}