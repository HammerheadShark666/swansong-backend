using Microsoft.AspNetCore.Http;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IArtistService
{
    Task<List<ArtistLookUpResponse>> SearchByNameAsync(string criteria);
    Task<List<ArtistLookUpResponse>> SearchByAlphaNumericAsync(string alphanumeric);
    Task<long> CountAsync();
    Task<List<ArtistResponse>> GetAllAsync(PaginationFilter filter);
    Task<List<ArtistResponse>> GetRandomAsync(int numberOfArtists);
    Task<ArtistResponse> GetAsync(long id);
    Task<ArtistPhotoActionResponse> UpdateArtistPhotoAsync(long id, IFormFile file); 
    Task<ArtistActionResponse> DeleteAsync(long id);
    Task<List<ArtistLookUpResponse>> GetLookupsAsync(); 
    Task<ArtistActionResponse> AddAsync(ArtistAddRequest artistAddRequest);
    Task<ArtistActionResponse> UpdateAsync(ArtistUpdateRequest artistUpdateRequest); 
}