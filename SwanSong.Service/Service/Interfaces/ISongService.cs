using SwanSong.Domain.Dto.Response;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface ISongService
{
    Task<SongActionResponse> DeleteAsync(long id);
}