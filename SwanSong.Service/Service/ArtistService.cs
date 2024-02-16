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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class ArtistService : IArtistService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Artist> _validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper;

    public record EditPhoto(bool photoWasChanged, string originalPhotoName);

    public ArtistService(IMapper mapper,
                         IValidatorHelper<Artist> validatorHelper,
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
        return await _unitOfWork.Artists.CountAsync();
    }

    public async Task<List<ArtistResponse>> GetAllAsync(PaginationFilter filter)
    {
        return _mapper.Map<List<ArtistResponse>>(await _unitOfWork.Artists.GetAllAsync(filter.PageNumber, filter.PageSize)).OrderBy(a => a.Name).ToList();
    }

    public async Task<List<ArtistResponse>> GetRandomAsync(int numberOfArtists)
    {
        return _mapper.Map<List<ArtistResponse>>(await _unitOfWork.Artists.GetRandomAsync(numberOfArtists)).OrderBy(a => a.Name).ToList();
    }

    public async Task<List<ArtistLookUpResponse>> SearchByNameAsync(string criteria)
    {
        return _mapper.Map<List<ArtistLookUpResponse>>(await _unitOfWork.Artists.SearchByNameAsync(criteria)); 
    }

    public async Task<List<ArtistLookUpResponse>> SearchByAlphaNumericAsync(string alphanumeric) 
    { 
        return _mapper.Map<List<ArtistLookUpResponse>>(await _unitOfWork.Artists.SearchByAlphaNumericAsync(alphanumeric)); 
    }

    public async Task<ArtistResponse> GetAsync(long id)
    {    
        return _mapper.Map<ArtistResponse>(await GetArtistAsync(id)); 
    }

    public async Task<ArtistPhotoActionResponse> UpdateArtistPhotoAsync(long id, IFormFile file)
    { 
        Artist artist = await GetArtistAsync(id);

        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = artist.Photo;
 
        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerArtists, newFileName);
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerArtists);
        await _unitOfWork.Artists.UpdateArtistPhotoAsync(id, newFileName);

        return new ArtistPhotoActionResponse(newFileName, true); 
    }

    public async Task<ArtistActionResponse> AddAsync(ArtistAddRequest artistAddRequest)
    { 
        Artist artist = _mapper.Map<Artist>(artistAddRequest);

        await BeforeSaveAsync(artist);
        await SaveAddAsync(artist);

        return await AfterSaveAsync(artist); 
    }

    public async Task<ArtistActionResponse> UpdateAsync(ArtistUpdateRequest artistUpdateRequest)
    {
        var artist = await UpdateArtistAsync(artistUpdateRequest);

        await BeforeSaveAsync(artist);
        await SaveUpdateAsync(artist);

        return await AfterSaveAsync(artist); 
    } 

    public async Task<ArtistActionResponse> DeleteAsync(long id)
    {
        var artist = await GetArtistWithMembersAsync(id);

        await BeforeDeleteAsync(artist);
        await DeleteAsync(artist);
        await DeleteArtistPhotosAsync(artist.Photo);
        await DeleteMembersPhotosAsync(artist.Members);

        return await AfterDeleteAsync(artist); 
    }
   
    public async Task<List<ArtistLookUpResponse>> GetLookupsAsync()
    {
        return _mapper.Map<List<ArtistLookUpResponse>>(await _unitOfWork.Artists.AllAsync()).OrderBy(a => a.Name).ToList();
    }

    #endregion

    #region Private Function

    private async Task<Artist> UpdateArtistAsync(ArtistUpdateRequest artistUpdateRequest)
    {
        Artist artist = await GetArtistAsync(artistUpdateRequest.Id);
        artist = _mapper.Map<ArtistUpdateRequest, Artist>(artistUpdateRequest, artist);
        return artist;
    }

    private async Task BeforeSaveAsync(Artist artist)
    {
        await _validatorHelper.ValidateAsync(artist, Constants.ValidationEventBeforeSave);
    }

    private async Task<ArtistActionResponse> AfterSaveAsync(Artist artist)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(artist, Constants.ValidationEventAfterSave);
        return new ArtistActionResponse(artist.Id, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(Artist artist)
    {
        await _validatorHelper.ValidateAsync(artist, Constants.ValidationEventBeforeDelete);
    }

    private async Task<ArtistActionResponse> AfterDeleteAsync(Artist artist)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(artist, Constants.ValidationEventAfterDelete);
        return new ArtistActionResponse(artist.Id, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    }

    private async Task DeleteAsync(Artist artist)
    {
        _unitOfWork.Artists.Delete(artist);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task SaveAddAsync(Artist artist)
    {
        await _unitOfWork.Artists.AddAsync(artist);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(Artist artist)
    {
        _unitOfWork.Artists.Update(artist);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task DeleteMembersPhotosAsync(List<Member> members)
    {
        foreach (Member member in members)
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(member.Photo, Constants.AzureStorageContainerMembers);
    }

    private async Task DeleteArtistPhotosAsync(string artistPhotoFileName)
    {
        if (NotDefaultImage(artistPhotoFileName))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(artistPhotoFileName, Constants.AzureStorageContainerArtists);
        }
    }

    private bool NotDefaultImage(string fileName)
    {
        return !(fileName == Constants.DefaultArtistPhotoFileName);
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

    private async Task<Artist> GetArtistWithMembersAsync(long id)
    {
        var artist = await _unitOfWork.Artists.ByIdWithMembersAsync(id);
        if (artist == null)
        {
            throw new ArtistNotFoundException("Artist not found.");
        }

        return artist;
    }

    private async Task<Artist> GetArtistAsync(long id)
    {
        var artist = await _unitOfWork.Artists.ByIdAsync(id);
        if (artist == null)
        {
            throw new ArtistNotFoundException("Artist not found.");
        }            

        return artist;
    }

    #endregion
}