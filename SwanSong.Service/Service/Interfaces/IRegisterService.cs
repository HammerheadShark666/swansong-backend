using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface IRegisterService
    {
        Task<RegisterDto> RegisterAsync(RegisterDto registerDto); 
    }
}