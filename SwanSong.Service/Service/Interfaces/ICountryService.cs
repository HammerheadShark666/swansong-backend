using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryReadOnlyDto>> GetAllAsync();
        Task<CountryDto> GetAsync(int id);
        Task<CountryDto> SaveAsync(CountryDto labelDto); 
        Task<CountryDto> DeleteAsync(int id);
    }
}