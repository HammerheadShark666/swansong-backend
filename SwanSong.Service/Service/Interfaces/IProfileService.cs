using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IProfileService
{
    Task<ProfileActionResponse> UpdateAsync(int id, ProfileRequest profileRequest);
    Task<ProfileResponse> GetAsync(int id);
}