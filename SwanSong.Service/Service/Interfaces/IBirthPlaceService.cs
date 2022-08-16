using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IBirthPlaceService
    {
        Task<List<BirthPlaceDto>> GetAllAsync();
        Task<BirthPlaceDto> GetAsync(int id);
        Task<BirthPlaceDto> SaveAsync(BirthPlaceDto birthPlaceDto);
        Task<BirthPlaceDto> DeleteAsync(int id);
    }
}