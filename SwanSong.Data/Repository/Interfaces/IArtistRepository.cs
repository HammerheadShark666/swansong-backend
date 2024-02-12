using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IArtistRepository
{       
    Task<IEnumerable<Artist>> SearchByNameAsync(string criteria);
    Task<IEnumerable<Artist>> SearchByAlphaNumericAsync(string alphanumeric);
    Task<long> CountAsync();
    Task<List<Artist>> GetAllAsync(int pageNumber, int pageSize);
    Task<List<Artist>> GetRandomAsync(int numberOfArtists);
    Task<Artist> GetAsync(long id); 
    Task<Artist> UpdateArtistPhotoAsync(long id, string filename);
    Task<bool> ExistsAsync(string name);
    Task<bool> ExistsAsync(long ignoreId, string name);
    Task<IEnumerable<Artist>> AllAsync();
    Task AddAsync(Artist artist);
    void Update(Artist artist);
    void Delete(Artist artist);
    Task<Artist> ByIdAsync(long id);
    Task<Artist> ByIdWithMembersAsync(long id);
}