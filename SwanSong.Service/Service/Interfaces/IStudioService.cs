using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IStudioService
{
    Task<List<StudioResponse>> GetAllAsync(); 
    Task<StudioActionResponse> AddAsync(StudioAddRequest studioAddRequest);
    Task<StudioActionResponse> UpdateAsync(StudioUpdateRequest studioUpdateRequest);
    Task<StudioActionResponse> DeleteAsync(int id);
}