using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IProfileService
    {
        Task<ProfileDto> UpdateAsync(int id, ProfileDto profileDto);
        Task<ProfileDto> GetAsync(int id);
    }
}
