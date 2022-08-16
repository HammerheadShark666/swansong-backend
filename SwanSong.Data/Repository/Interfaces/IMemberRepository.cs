using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces
{
    public interface IMemberRepository : IBaseRepository<Member>
    {
        Task<bool> ExistsAsync(long ignoreId, long? artistId, string stageName);
        Task<bool> ExistsAsync(long? artistId, string stageName);
        Task<bool> ExistsAsync(string stageName);
        Task<bool> ExistsAsync(long id, string stageName);
        Task<long> CountAsync();
        Task<List<Member>> GetAllAsync(int pageNumber, int pageSize);
        Task<List<Member>> GetRandomAsync(int numberOfMembers);
        Task<Member> GetAsync(string stageName);
        Task<Member> GetAsync(long id);
        Task<Member> GetAsync(long id, string stageName);
        Task<IEnumerable<Member>> GetMembersByArtistAsync(long artistId);
        Task<List<Member>> SearchByNameAsync(string criteria);
        Task<List<Member>> SearchByLetterAsync(string letter);
        Task<Member> UpdateMemberPhotoAsync(long id, string filename);
    }
}
