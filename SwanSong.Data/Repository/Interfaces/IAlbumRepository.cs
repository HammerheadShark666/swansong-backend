﻿using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IAlbumRepository : IBaseRepository<Album>
    {
        Task<IEnumerable<Album>> SearchByNameAsync(string criteria);
        Task<IEnumerable<Album>> SearchByLetterAsync(string letter);
        Task<IEnumerable<Album>> GetAlbumsForArtistAsync(long artistId);
        Task<long> CountAsync();
        Task<List<Album>> GetAllAsync(int pageNumber, int pageSize);
        Task<List<Album>> GetRandomAsync(int numberOfAlbums);
        Task<Album> GetAsync(long id);
        Task<Album> GetAsync(long artistId, string name);
        Task<Album> GetAsync(long id, long artistId, string name);
        Task<Album> UpdateAlbumPhotoAsync(long id, string filename);
        Task<bool> ExistsAsync(string name);
        Task<bool> ExistsAsync(long id, string name);         
    }
}
