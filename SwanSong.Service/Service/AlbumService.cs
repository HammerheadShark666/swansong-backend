using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.Helper;
using SwanSong.Data.MediatR.Commands;
using SwanSong.Data.MediatR.Queries;
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

public class AlbumService : BaseService, IAlbumService
{     
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Album> _validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper;
    private readonly IMediator _mediator;

    public record EditPhoto(bool photoWasChanged, string originalPhotoName);

    public AlbumService(IMapper mapper,
                        IMediator mediator,
                        IValidatorHelper<Album> validatorHelper,
                        IMemoryCache memoryCache, 
                        IAzureStorageBlobHelper azureStorageHelper) : base(memoryCache)
    {
        _azureStorageHelper = azureStorageHelper;
        _validatorHelper = validatorHelper; 
        _mediator = mediator;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<long> CountAsync()
    {
        return await _mediator.Send(new GetAlbumCountQuery()); 
    }

    public async Task<List<AlbumLookUpResponse>> GetAllAsync(PaginationFilter paginationFilter)
    { 
        return _mapper.Map<List<AlbumLookUpResponse>>(await _mediator.Send(new GetAlbumsByPageQuery(paginationFilter))); 
    }

    public async Task<List<AlbumLookUpResponse>> GetRandomAsync(int numberOfAlbums)
    { 
        return GetAlbumLookUps((await _mediator.Send(new GetAlbumsRandomQuery(numberOfAlbums))).OrderBy(a => a.Name).ToList()); 
    } 

    public async Task<List<AlbumLookUpResponse>> GetByNameAsync(string name)
    { 
        return _mapper.Map<List<AlbumLookUpResponse>>(await _mediator.Send(new GetAlbumsByNameQuery(name))); 
    } 

    public async Task<List<AlbumLookUpResponse>> GetByLetterAsync(string letter)
    {
        return _mapper.Map<List<AlbumLookUpResponse>>(await _mediator.Send(new GetAlbumsByLetterQuery(letter))); 
    } 

    public async Task<List<AlbumLookUpResponse>> GetAlbumsForArtistAsync(long artistId)
    {
        return _mapper.Map<List<AlbumLookUpResponse>>(await _mediator.Send(new GetAlbumsByArtistQuery(artistId))); 
    } 

    public async Task<AlbumResponse> GetAsync(long id)
    {
        return _mapper.Map<AlbumResponse>(await _mediator.Send(new GetAlbumByIdQuery(id))); 
    } 

    public async Task<AlbumActionResponse> AddAsync(AlbumAddRequest albumAddRequest)
    {
        var album = _mapper.Map<Album>(albumAddRequest);

        await BeforeSaveAsync(album);
        album = await SaveAddAsync(album, CacheKeys.Country);

        return await AfterSaveAsync(album); 
    } 

    public async Task<AlbumActionResponse> UpdateAsync(AlbumUpdateRequest albumUpdateRequest)
    { 
        var album = await GetUpdatedAlbumAsync(albumUpdateRequest);
         
        await BeforeSaveAsync(album);
        await SaveUpdateAsync(album, null);

        return await AfterSaveAsync(album);
    } 

    public async Task<AlbumActionResponse> DeleteAsync(long id)
    {
        var album = await GetExistingAlbumAsync(id);
         
        await BeforeDeleteAsync(album); 
        await _mediator.Send(new DeleteAlbumCommand(album));

        if (NotDefaultImage(album.Photo))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(album.Photo, Constants.AzureStorageContainerAlbums);
        }

        return await AfterDeleteAsync(album);
    }
  
    public async Task<AlbumPhotoActionResponse> UpdateAlbumPhotoAsync(long id, IFormFile file)
    {  
        var album = await GetExistingAlbumAsync(id);

        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = album.Photo;

        album.Photo = newFileName;

        _mapper.Map<AlbumResponse>(await _mediator.Send(new UpdateAlbumCommand(album)));
         
        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerAlbums, newFileName);
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerAlbums);

        return new AlbumPhotoActionResponse(newFileName, true); 
    }

    #endregion

    #region Private Functions
     
    private async Task<Album> GetUpdatedAlbumAsync(AlbumUpdateRequest albumUpdateRequest)
    {
        var album = await _mediator.Send(new GetAlbumByIdQuery(albumUpdateRequest.Id));
        if (album == null)
        {
            throw new AlbumNotFoundException("Album Not Found.");
        }

        album = _mapper.Map<AlbumUpdateRequest, Album>(albumUpdateRequest, album);

        return album;
    }

    private async Task<Album> GetExistingAlbumAsync(long id)
    {
        var album = await _mediator.Send(new GetAlbumByIdQuery(id));
        if (album == null)
        {
            throw new AlbumNotFoundException("Album Not Found.");
        } 
        
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

    private async Task<Album> SaveAddAsync(Album album, string cacheKey)
    {
        album = await _mediator.Send(new CreateAlbumCommand(album));
        ClearCache(cacheKey);
        return album;
    } 

    private async Task<Album> SaveUpdateAsync(Album album, string cacheKey)
    {
        album = await _mediator.Send(new UpdateAlbumCommand(album));
        ClearCache(cacheKey);
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

    private List<AlbumLookUpResponse> GetAlbumLookUps(List<Album> albums)
    {
        List<AlbumLookUpResponse> albumLookUpResponses = _mapper.Map<List<AlbumLookUpResponse>>(albums);

        for (int i = 0; i < albumLookUpResponses.Count; i++)
        {
            List<AlbumSong> albumSongs = albums.First(a => a.Id.Equals(albumLookUpResponses[i].Id)).AlbumSongs.ToList();
            albumLookUpResponses[i] = albumLookUpResponses[i] with { Tracks = albumSongs.Count().ToString(), Length = GetAlbumLength(albumSongs.ToList()) };
        }

        return albumLookUpResponses;
    }

    #endregion
}