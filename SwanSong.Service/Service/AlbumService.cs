using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Filter;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class AlbumService : IAlbumService
{

    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Album> _validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper;

    public record EditPhoto(bool photoWasChanged, string originalPhotoName);

    public AlbumService(IMapper mapper,
                        IValidatorHelper<Album> validatorHelper,
                        IMemoryCache memoryCache,
                        IUnitOfWork unitOfWork,
                        IAzureStorageBlobHelper azureStorageHelper)
    {
        _azureStorageHelper = azureStorageHelper;
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<long> CountAsync()
    {
        return await _unitOfWork.Albums.CountAsync();
    }

    public async Task<List<AlbumLookUpResponse>> GetAllAsync(PaginationFilter filter)
    { 
        return _mapper.Map<List<AlbumLookUpResponse>>(await _unitOfWork.Albums.GetAllAsync(filter.PageNumber, filter.PageSize));
    }

    public async Task<List<AlbumLookUpResponse>> GetRandomAsync(int numberOfAlbums)
    { 
        return GetAlbumLookUps((await _unitOfWork.Albums.GetRandomAsync(numberOfAlbums)).OrderBy(a => a.Name).ToList());
    }

    public List<AlbumLookUpResponse> GetAlbumLookUps(List<Album> albums)
    {
        List<AlbumLookUpResponse> albumLookUpResponses = _mapper.Map<List<AlbumLookUpResponse>>(albums);
         
        for (int i = 0; i < albumLookUpResponses.Count; i++)
        {
            List<AlbumSong> albumSongs = albums.First(a => a.Id.Equals(albumLookUpResponses[i].Id)).AlbumSongs.ToList();
            albumLookUpResponses[i] = albumLookUpResponses[i] with { Tracks = albumSongs.Count().ToString(), Length = GetAlbumLength(albumSongs.ToList()) };
        } 

        return albumLookUpResponses;
    } 

    public async Task<List<AlbumLookUpResponse>> SearchByNameAsync(string criteria)
    {
        return _mapper.Map<List<AlbumLookUpResponse>>(await _unitOfWork.Albums.SearchByNameAsync(criteria));
    }

    public async Task<List<AlbumLookUpResponse>> SearchByLetterAsync(string letter)
    {
        return _mapper.Map<List<AlbumLookUpResponse>>(await _unitOfWork.Albums.SearchByLetterAsync(letter));
    }

    public async Task<List<AlbumLookUpResponse>> GetAlbumsForArtistAsync(long artistId)
    {
        return _mapper.Map<List<AlbumLookUpResponse>>(await _unitOfWork.Albums.GetAlbumsForArtistAsync(artistId));
    }

    public async Task<AlbumResponse> GetAsync(long id)
    {
        return _mapper.Map<AlbumResponse>(await _unitOfWork.Albums.GetAsync(id));
    }

    public async Task<AlbumActionResponse> AddAsync(AlbumAddRequest albumAddRequest)
    {
        Album album = _mapper.Map<Album>(albumAddRequest);

        await BeforeSaveAsync(album);
        await SaveAddAsync(album); 

        return await AfterSaveAsync(album);
    }

    public async Task<AlbumActionResponse> UpdateAsync(AlbumUpdateRequest albumUpdateRequest)
    {
        var album = await UpdateAlbumAsync(albumUpdateRequest);

        await BeforeSaveAsync(album);
        await SaveUpdateAsync(album);

        return await AfterSaveAsync(album);
    }

    public async Task<AlbumActionResponse> DeleteAsync(long id)
    {
        var album = await GetAlbumAsync(id);

        await BeforeDeleteAsync(album);
        await DeleteAsync(album);

        if (NotDefaultImage(album.Photo))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(album.Photo, Constants.AzureStorageContainerAlbums);
        }

        return await AfterDeleteAsync(album);
    }

    public async Task<AlbumPhotoActionResponse> UpdateAlbumPhotoAsync(long id, IFormFile file)
    {
        var album = await GetAlbumAsync(id);

        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = album.Photo;

        _mapper.Map<AlbumResponse>(await _unitOfWork.Albums.UpdateAlbumPhotoAsync(id, newFileName));

        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerAlbums, newFileName);
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerAlbums);

        return new AlbumPhotoActionResponse(newFileName, true); 
    }

    #endregion

    #region Private Functions

    private async Task<Album> UpdateAlbumAsync(AlbumUpdateRequest albumUpdateRequest)
    {
        Album album = await GetAlbumAsync(albumUpdateRequest.Id);
        album = _mapper.Map<AlbumUpdateRequest, Album>(albumUpdateRequest, album);

        return album;
    }

    private async Task BeforeSaveAsync(Album album)
    {
        await _validatorHelper.ValidateAsync(album, Constants.ValidationEventBeforeSave);
    }

    private async Task<AlbumActionResponse> AfterSaveAsync(Album album)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(album, Constants.ValidationEventAfterSave);
        return new AlbumActionResponse(album.Id, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(Album album)
    {
        await _validatorHelper.ValidateAsync(album, Constants.ValidationEventBeforeDelete);
    }

    private async Task<AlbumActionResponse> AfterDeleteAsync(Album album)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(album, Constants.ValidationEventAfterDelete);
        return new AlbumActionResponse(album.Id, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    }
      
    private async Task SaveAddAsync(Album album)
    {
        await _unitOfWork.Albums.AddAsync(album);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(Album album)
    {
        _unitOfWork.Albums.Update(album);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task DeleteAsync(Album album)
    {
        _unitOfWork.Albums.Delete(album);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }
     
    private async Task<Album> GetAlbumAsync(long id)
    {
        var album = await _unitOfWork.Albums.ByIdAsync(id);
        if (album == null)
        {
            throw new AlbumNotFoundException("Album not found.");
        }

        return album;
    }

    private bool NotDefaultImage(string fileName)
    {
        return !(fileName == Constants.DefaultAlbumPhotoFileName);
    }

    private async Task DeleteOriginalFileAsync(string originalFileName, string newFileName, string container)
    {
        EditPhoto editPhoto = WasPhotoEdited(originalFileName, newFileName);
        if (editPhoto.photoWasChanged)
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(editPhoto.originalPhotoName, container);
        }
    }

    private EditPhoto WasPhotoEdited(string originalPhotoFileName, string newPhotoFileName)
    {
        return new EditPhoto(((originalPhotoFileName != null && newPhotoFileName != null && NotDefaultImage(originalPhotoFileName))
                                    && (originalPhotoFileName != newPhotoFileName)), originalPhotoFileName);
    } 
     
    private string GetAlbumLength(List<AlbumSong> albumSongs)
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

    #endregion
}