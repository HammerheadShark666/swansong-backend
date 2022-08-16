using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IStudioService
    {
        Task<List<StudioReadOnlyDto>> GetAllAsync();
        Task<StudioDto> GetAsync(int id);
        Task<StudioDto> SaveAsync(StudioDto studioDto);
        Task<StudioDto> DeleteAsync(int id);
    }
}