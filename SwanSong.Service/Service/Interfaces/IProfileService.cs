using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IProfileService
{
    Task<ProfileActionResponse> UpdateAsync(int id, ProfileRequest profileRequest);
    Task<ProfileResponse> GetAsync(int id);
}