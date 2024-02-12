using Microsoft.AspNetCore.Http;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IMemberService
{
    Task<long> CountAsync();
    Task<List<MemberResponse>> GetAllAsync(PaginationFilter filter);
    Task<List<MemberResponse>> GetRandomAsync(int numberOfMember);
    Task<List<MemberResponse>> SearchByNameAsync(string criteria);
    Task<List<MemberResponse>> SearchByLetterAsync(string letter);
    Task<List<MemberResponse>> GetMembersByArtistAsync(long artistId);
    Task<MemberActionResponse> AddAsync(MemberAddRequest memberAddRequest);
    Task<MemberActionResponse> UpdateAsync(MemberUpdateRequest memberUpdateRequest);
    Task<MemberActionResponse> DeleteAsync(long id);
    Task<MemberResponse> GetAsync(long id);
    Task<MemberPhotoActionResponse> UpdateMemberPhotoAsync(long id, IFormFile file);
}