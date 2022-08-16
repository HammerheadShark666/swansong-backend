using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using SwanSong.Data.UnitOfWork.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using SwanSong.Azure.Storage.Interfaces;

namespace SwanSong.Service
{
    public class AlbumSongService : BaseService<AlbumSong, AlbumSongDto>, IAlbumSongService
    {
        public AlbumSongService(IMapper mapper,
                                IValidator<AlbumSong> validator,
                                IMemoryCache memoryCache,
                                IUnitOfWork unitOfWork,
                                IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<List<AlbumSongDto>> GetAlbumSongsAsync(long albumId)
        {
            return _mapper.Map<List<AlbumSongDto>>(await _unitOfWork.AlbumSongs.GetAlbumSongsAsync(albumId)); 
        }

        public async Task<AlbumSongDto> GetAlbumSongAsync(long albumId, long songId)
        {
            return _mapper.Map<AlbumSongDto>(await _unitOfWork.AlbumSongs.GetAsync(albumId, songId)); 
        }

        public async Task<AlbumSongDto> SaveAsync(AlbumSongDto albumSongDto)
        { 
            AlbumSong albumSong = await GetAlbumSongAsync(albumSongDto);
          
            ValidationResult result = await BeforeSaveAsync(albumSong);
            if (!result.IsValid)
                return GetDto(albumSong, result.Errors, false);

            albumSong = await SaveAsync(albumSong);

            return GetDto(albumSong, await AfterSaveAsync(albumSong, null), true);  
        }

        public async Task<AlbumSongDto> DeleteAsync(long id)
        {  
            AlbumSong albumSong = await _unitOfWork.AlbumSongs.GetAsync(id);
          
            ValidationResult result = await BeforeDeleteAsync(albumSong);
            if (!result.IsValid)
                return GetDto(albumSong, result.Errors, false); 

            albumSong = await DeleteAsync(albumSong);

            return GetDto(albumSong, await AfterDeleteAsync(albumSong, null), true); 
        } 

        private async Task<AlbumSong> GetAlbumSongAsync(AlbumSongDto albumSongDto)
        {
            AlbumSong currentAlbumSong = albumSongDto.Id == 0 ? new() : await _unitOfWork.AlbumSongs.GetAsync(albumSongDto.Id);
            return _mapper.Map<AlbumSongDto, AlbumSong>(albumSongDto, currentAlbumSong);
        }

        private async Task<AlbumSong> SaveAsync(AlbumSong albumSong)
        {
            if (albumSong.Id == 0)
                _unitOfWork.AlbumSongs.Add(albumSong);
            else
                _unitOfWork.AlbumSongs.Update(albumSong);

            await _unitOfWork.Complete();

            return albumSong;
        }

        private async Task<AlbumSong> DeleteAsync(AlbumSong albumSong)
        {
            _unitOfWork.AlbumSongs.Remove(albumSong);
            await _unitOfWork.Complete();

            return albumSong;
        }
    }
}
