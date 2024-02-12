using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class AlbumSongService : IAlbumSongService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<AlbumSong> _validatorHelper; 

    public AlbumSongService(IMapper mapper,
                            IValidatorHelper<AlbumSong> validatorHelper,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork)
    { 
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<List<AlbumSongResponse>> GetAlbumSongsAsync(long albumId)
    { 
        return _mapper.Map<List<AlbumSongResponse>>(await _unitOfWork.AlbumSongs.GetAlbumSongsAsync(albumId)); 
    } 

    public async Task<AlbumSongActionResponse> AddAsync(AlbumSongAddRequest albumSongAddRequest)
    {
        AlbumSong albumSong = _mapper.Map<AlbumSong>(albumSongAddRequest);

        await BeforeSaveAsync(albumSong);
        await SaveAddAsync(albumSong, null);

        return await AfterSaveAsync(albumSong);
    }

    public async Task<AlbumSongActionResponse> UpdateAsync(AlbumSongUpdateRequest albumSongUpdateRequest)
    {
        var albumSong = await UpdateAlbumSong(albumSongUpdateRequest);

        await BeforeSaveAsync(albumSong);
        await SaveUpdateAsync(albumSong, null);

        return await AfterSaveAsync(albumSong); 
    }

    public async Task<AlbumSongActionResponse> DeleteAsync(long id)
    {
        var albumSong = await GetAlbumSongAsync(id);

        await BeforeDeleteAsync(albumSong);
        await DeleteAsync(albumSong, null);

        return await AfterDeleteAsync(albumSong); 
    }

    #endregion

    #region Private Functions

    private async Task<AlbumSong> UpdateAlbumSong(AlbumSongUpdateRequest albumSongUpdateRequest)
    { 
        AlbumSong albumSong = await GetAlbumSongAsync(albumSongUpdateRequest.Id);
        albumSong = _mapper.Map<AlbumSongUpdateRequest, AlbumSong>(albumSongUpdateRequest, albumSong);
        return albumSong;
    }

    private async Task BeforeSaveAsync(AlbumSong albumSong)
    {
        await _validatorHelper.ValidateAsync(albumSong, Constants.ValidationEventBeforeSave);
    }

    private async Task<AlbumSongActionResponse> AfterSaveAsync(AlbumSong albumSong)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(albumSong, Constants.ValidationEventAfterSave);
        return new AlbumSongActionResponse(albumSong.Id, albumSong.SongId, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(AlbumSong albumSong)
    {
        await _validatorHelper.ValidateAsync(albumSong, Constants.ValidationEventBeforeDelete);
    }

    private async Task<AlbumSongActionResponse> AfterDeleteAsync(AlbumSong albumSong)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(albumSong, Constants.ValidationEventAfterDelete);
        return new AlbumSongActionResponse(albumSong.Id, albumSong.SongId, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    }

    private async Task DeleteAsync(AlbumSong albumSong, string cacheKey)
    {
        _unitOfWork.AlbumSongs.Delete(albumSong);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveAddAsync(AlbumSong albumSong, string cacheKey)
    {
        await _unitOfWork.AlbumSongs.AddAsync(albumSong);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(AlbumSong albumSong, string cacheKey)
    {
        _unitOfWork.AlbumSongs.Update(albumSong);
        await DataHelper.CompleteContextAction(cacheKey, _memoryCache, _unitOfWork);
    } 
 
    private async Task<AlbumSong> GetAlbumSongAsync(long id)
    {
        var albumSong = await _unitOfWork.AlbumSongs.ByIdAsync(id);
        if (albumSong == null)
        {
            throw new AlbumSongNotFoundException("Album Song not found.");
        }            

        return albumSong;
    }

    #endregion
}