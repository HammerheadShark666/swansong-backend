using Microsoft.AspNetCore.Http;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IArtistService
    {
        Task<List<ArtistReadOnlyDto>> SearchByNameAsync(string criteria);
        Task<List<ArtistReadOnlyDto>> SearchByAlphaNumericAsync(string alphanumeric);
        Task<long> CountAsync();
        Task<List<ArtistReadOnlyDto>> GetAllAsync(PaginationFilter filter);
        Task<List<ArtistReadOnlyDto>> GetRandomAsync(int numberOfArtists);
        Task<ArtistDto> GetAsync(long id);
        Task<string> UpdateArtistPhotoAsync(long id, IFormFile file);
        Task<ArtistDto> SaveAsync(ArtistDto artist);
        Task<ArtistDto> DeleteAsync(long id);
        Task<List<ArtistLookupDto>> GetLookupsAsync();
    }
}