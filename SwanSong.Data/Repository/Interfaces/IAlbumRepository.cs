using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IAlbumRepository
{
    Task<List<Album>> GetByNameAsync(string criteria);
    Task<List<Album>> GetByLetterAsync(string letter);
    Task<List<Album>> GetAlbumsForArtistAsync(long artistId);
    Task<long> CountAsync();
    Task<List<Album>> GetAllAsync(int pageNumber, int pageSize);
    Task<List<Album>> GetRandomAsync(int numberOfAlbums);
    Task<Album> GetAsync(long id); 
    Task<bool> ExistsAsync(string name);
    Task<bool> ExistsAsync(long id, string name);
    Task<Album> AddAsync(Album album);
    Task<Album> UpdateAsync(Album album);
    Task<Album> DeleteAsync(Album album);
    Task<Album> ByIdAsync(long id);
}