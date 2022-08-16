using FluentValidation.Results;
using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces
{
    public interface ISongService
    {  
        Task<SongDto> DeleteAsync(int id);
    }
}