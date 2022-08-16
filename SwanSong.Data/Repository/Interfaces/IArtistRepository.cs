using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IArtistRepository : IBaseRepository<Artist>
    {       
        Task<IEnumerable<Artist>> SearchByNameAsync(string criteria);
        Task<IEnumerable<Artist>> SearchByAlphaNumericAsync(string alphanumeric);
        Task<long> CountAsync();
        Task<List<Artist>> GetAllAsync(int pageNumber, int pageSize);
        Task<List<Artist>> GetRandomAsync(int numberOfArtists);
        Task<Artist> GetAsync(long id);
        Task<Artist> GetAsync(string name);
        Task<Artist> GetAsync(long id, string name);
        Task<Artist> GetWithMembersAsync(long id);
        Task<Artist> UpdateArtistPhotoAsync(long id, string filename);
        Task<bool> ExistsAsync(string name);
        Task<bool> ExistsAsync(long ignoreId, string name);
    }
}
