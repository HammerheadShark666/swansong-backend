using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRegisterService
{
    Task<RegisterActionResponse> RegisterAsync(RegisterRequest registerRequest); 
}