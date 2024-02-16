using SwanSong.Data.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace SwanSong.Data.UnitOfWork.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    IAlbumRepository Albums { get; }
    IAlbumSongRepository AlbumSongs { get; }
    IArtistRepository Artists { get; }
    IBirthPlaceRepository BirthPlaces { get; }
    ICountryRepository Countries { get; }
    IMemberRepository Members { get; }
    IRefreshTokenRepository RefreshTokens { get; }
    IRecordLabelRepository RecordLabels { get; }
    ISongRepository Songs { get; }
    IStudioRepository Studios { get; } 
    
    Task<int> CompleteAsync();
    int Complete();
}