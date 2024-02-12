using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface ICountryService
{
    Task<List<CountryResponse>> GetAllAsync(); 
    Task<CountryActionResponse> AddAsync(CountryAddRequest countryAddRequest);
    Task<CountryActionResponse> UpdateAsync(CountryUpdateRequest countryUpdateRequest);
    Task<CountryActionResponse> DeleteAsync(int id);
}