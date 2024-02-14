using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IBirthPlaceService
{
    Task<List<BirthPlaceResponse>> GetAllAsync(); 
    Task<BirthPlaceActionResponse> AddAsync(BirthPlaceAddRequest birthPlaceAddRequest);
    Task<BirthPlaceActionResponse> UpdateAsync(BirthPlaceUpdateRequest birthPlaceUpdateRequest);
    Task<BirthPlaceActionResponse> DeleteAsync(int id);
}