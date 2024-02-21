using Microsoft.AspNetCore.Http;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IAlbumService
{
    Task<List<AlbumLookUpResponse>> GetByNameAsync(string criteria);
    Task<List<AlbumLookUpResponse>> GetByLetterAsync(string letter);
    Task<List<AlbumLookUpResponse>> GetAlbumsForArtistAsync(long artistId);
    Task<long> CountAsync();
    Task<List<AlbumLookUpResponse>> GetAllAsync(PaginationFilter filter);
    Task<List<AlbumLookUpResponse>> GetRandomAsync(int numberOfAlbums);
    Task<AlbumResponse> GetAsync(long id); 
    Task<AlbumPhotoActionResponse> UpdateAlbumPhotoAsync(long id, IFormFile file);
    Task<AlbumActionResponse> DeleteAsync(long id); 
    Task<AlbumActionResponse> AddAsync(AlbumAddRequest albumAddRequest);
    Task<AlbumActionResponse> UpdateAsync(AlbumUpdateRequest albumUpdateRequest);
}