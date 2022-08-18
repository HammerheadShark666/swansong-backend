using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class AlbumService : BaseService<Album, AlbumDto>, IAlbumService
    {
        public AlbumService(IMapper mapper,
                            IValidator<Album> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork,
                            IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<long> CountAsync()
        {
            return await _unitOfWork.Albums.CountAsync();
        }

        public async Task<List<AlbumReadOnlyDto>> GetAllAsync(PaginationFilter filter)
        {
            return _mapper.Map<List<AlbumReadOnlyDto>>(await _unitOfWork.Albums.GetAllAsync(filter.PageNumber, filter.PageSize));
        }

        public async Task<List<AlbumReadOnlyDto>> GetRandomAsync(int numberOfAlbums)
        { 
            return GetAlbumReadOnlyDtos((await _unitOfWork.Albums.GetRandomAsync(numberOfAlbums)).OrderBy(a => a.Name).ToList());
        }

        public List<AlbumReadOnlyDto> GetAlbumReadOnlyDtos(List<Album> albums)
        {
            List<AlbumReadOnlyDto> albumsReadOnlyDtos = _mapper.Map<List<AlbumReadOnlyDto>>(albums);

            foreach (AlbumReadOnlyDto albumsReadOnlyDto in albumsReadOnlyDtos)
            {
                List<AlbumSong> albumSongs = albums.First(a => a.Id.Equals(albumsReadOnlyDto.Id)).AlbumSongs.ToList();
                albumsReadOnlyDto.Tracks = albumSongs.Count().ToString();
                albumsReadOnlyDto.Length = GetAlbumLength(albumSongs.ToList());
            } 

            return albumsReadOnlyDtos;
        } 

        public async Task<List<AlbumReadOnlyDto>> SearchByNameAsync(string criteria)
        {
            return _mapper.Map<List<AlbumReadOnlyDto>>(await _unitOfWork.Albums.SearchByNameAsync(criteria));
        }

        public async Task<List<AlbumReadOnlyDto>> SearchByLetterAsync(string letter)
        {
            return _mapper.Map<List<AlbumReadOnlyDto>>(await _unitOfWork.Albums.SearchByLetterAsync(letter));
        }

        public async Task<List<AlbumReadOnlyDto>> GetAlbumsForArtistAsync(long artistId)
        {
            return _mapper.Map<List<AlbumReadOnlyDto>>(await _unitOfWork.Albums.GetAlbumsForArtistAsync(artistId));
        }

        public async Task<AlbumDto> GetAsync(long id)
        {
            return _mapper.Map<AlbumDto>(await _unitOfWork.Albums.GetAsync(id));
        }

        public async Task<AlbumDto> SaveAsync(AlbumDto albumDto)
        {
            Album album = await GetAlbum(albumDto);

            ValidationResult result = await BeforeSaveAsync(album);
            if (!result.IsValid)
                return GetDto(album, result.Errors, false);

            album = await SaveAsync(album);

            return GetDto(album, await AfterSaveAsync(album, null), true);
        }

        public async Task<AlbumDto> DeleteAsync(long id)
        {
            Album album = await _unitOfWork.Albums.GetAsync(id);

            ValidationResult result = await BeforeDeleteAsync(album);
            if (!result.IsValid)
                return GetDto(album, result.Errors, false);

            await DeleteAsync(album);

            if (notDefaultImage(album.Photo))
                await _azureStorageHelper.DeleteFileInAzureStorageContainerAsync(album.Photo, Constants.AzureStorageContainerAlbums);

            return GetDto(album, await AfterDeleteAsync(album, null), true);
        }

        public async Task<string> UpdateAlbumPhotoAsync(long id, IFormFile file)
        {
            Album album = await _unitOfWork.Albums.GetAsync(id);
            if (album == null)
                throw new Exception(ConstantMessages.AlbumNotFound);

            string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
            string originalFileName = album.Photo;

            AlbumDto albumDto = _mapper.Map<AlbumDto>(await _unitOfWork.Albums.UpdateAlbumPhotoAsync(id, newFileName));

            await _azureStorageHelper.SaveFileToAzureStorageContainerAsync(file, Constants.AzureStorageContainerAlbums, newFileName);
            await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerAlbums);

            return newFileName;
        }

        private async Task<Album> GetAlbum(AlbumDto albumDto)
        {
            Album currentAlbum = albumDto.Id == 0 ? new() : await _unitOfWork.Albums.GetAsync(albumDto.Id);
            return _mapper.Map<AlbumDto, Album>(albumDto, currentAlbum);
        }

        private async Task<Album> SaveAsync(Album album)
        {
            if (album.Id == 0)
                _unitOfWork.Albums.Add(album);
            else
                _unitOfWork.Albums.Update(album);

            await _unitOfWork.Complete();

            return album;
        }

        private async Task DeleteAsync(Album album)
        {
            _unitOfWork.Albums.Remove(album);
            await _unitOfWork.Complete();
        }

        public string GetAlbumLength(List<AlbumSong> albumSongs)
        {
            TimeSpan time = new TimeSpan();

            foreach (AlbumSong albumSong in albumSongs)
            {
                try
                {
                    string[] timeParts = albumSong.Song.Length.Split(':');
                    TimeSpan t = new TimeSpan(0, int.Parse(timeParts[0]), int.Parse(timeParts[1]));
                    time = time.Add(t);
                }
                catch { }
            }

            return time.ToString();
        }
    }
}