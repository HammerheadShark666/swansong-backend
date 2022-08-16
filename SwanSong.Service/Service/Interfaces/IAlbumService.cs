using Microsoft.AspNetCore.Http;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IAlbumService
    {
        Task<List<AlbumReadOnlyDto>> SearchByNameAsync(string criteria);
        Task<List<AlbumReadOnlyDto>> SearchByLetterAsync(string letter);
        Task<List<AlbumReadOnlyDto>> GetAlbumsForArtistAsync(long artistId);
        Task<long> CountAsync();
        Task<List<AlbumReadOnlyDto>> GetAllAsync(PaginationFilter filter);
        Task<List<AlbumReadOnlyDto>> GetRandomAsync(int numberOfAlbums);
        Task<AlbumDto> GetAsync(long id);
        Task<AlbumDto> SaveAsync(AlbumDto album);
        Task<AlbumDto> DeleteAsync(long id);
        Task<string> UpdateAlbumPhotoAsync(long id, IFormFile file);
    }
}