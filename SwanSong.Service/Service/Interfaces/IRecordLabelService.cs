using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRecordLabelService
{
    Task<List<RecordLabelResponse>> GetAllAsync(); 
    Task<RecordLabelActionResponse> AddAsync(RecordLabelAddRequest recordLabelAddRequest);
    Task<RecordLabelActionResponse> UpdateAsync(RecordLabelUpdateRequest recordLabelUpdateRequest);
    Task<RecordLabelActionResponse> DeleteAsync(int id);
}