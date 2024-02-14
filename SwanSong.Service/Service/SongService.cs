using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class SongService : ISongService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Song> _validatorHelper;
    public SongService(IMapper mapper,
                       IValidatorHelper<Song> validatorHelper,
                       IMemoryCache memoryCache,
                       IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<SongActionResponse> DeleteAsync(long id)
    {
        var song = await GetSongAsync(id);

        await BeforeDelete(song);
        await DeleteAsync(song);

        return await AfterDelete(song);
    }

    #endregion

    #region Private Functions

    private async Task BeforeDelete(Song song)
    {
        await _validatorHelper.ValidateAsync(song, Constants.ValidationEventBeforeDelete);
    }

    private async Task<SongActionResponse> AfterDelete(Song song)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(song, Constants.ValidationEventAfterDelete);
        return new SongActionResponse(song.Id, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    } 

    private async Task DeleteAsync(Song song)
    {
        _unitOfWork.Songs.Delete(song);
        await DataHelper.CompleteContextAction(null, _memoryCache, _unitOfWork);
    }

    private async Task<Song> GetSongAsync(long id)
    {
        var song = await _unitOfWork.Songs.ByIdAsync(id);
        if (song == null)
        {
            throw new SongNotFoundException("Song not found.");
        }

        return song;
    }

    #endregion

}