using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IMemberService
    {
        Task<long> CountAsync();
        Task<List<MemberReadOnlyDto>> GetAllAsync(PaginationFilter filter);
        Task<List<MemberReadOnlyDto>> GetRandomAsync(int numberOfMember);
        Task<List<MemberReadOnlyDto>> SearchByNameAsync(string criteria);
        Task<List<MemberReadOnlyDto>> SearchByLetterAsync(string letter);
        Task<List<MemberDto>> GetMembersByArtistAsync(long artistId);
        Task<MemberDto> SaveAsync(MemberDto memberDto);        
        Task<MemberDto> DeleteAsync(long id);
        Task<MemberDto> GetAsync(long id);
        Task<string> UpdateMemberPhotoAsync(long id, IFormFile file);
    }
}