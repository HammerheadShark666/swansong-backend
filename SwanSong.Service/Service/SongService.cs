using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class SongService : BaseService<Song, SongDto>, ISongService
    {
        public SongService(IMapper mapper,
                           IValidator<Song> validator,
                           IMemoryCache memoryCache,
                           IUnitOfWork unitOfWork,
                           IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }
      
        public async Task<SongDto> DeleteAsync(int id)
        {
            Song song = await _unitOfWork.Songs.GetByIdAsync(id);

            ValidationResult result = BeforeDelete(song);
            if (!result.IsValid)
                return GetDto(song, result.Errors, false);

            song = await DeleteAsync(song);

            return GetDto(song, AfterDelete(song, CacheKeys.Studio), true);
        } 

        private async Task<Song> DeleteAsync(Song song)
        {
            _unitOfWork.Songs.Remove(song);
            await _unitOfWork.Complete();

            return song;
        } 
    }
}
