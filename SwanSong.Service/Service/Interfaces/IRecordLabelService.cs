using SwanSong.Domain.Dto;
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