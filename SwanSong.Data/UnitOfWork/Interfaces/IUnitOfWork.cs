using SwanSong.Data.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace SwanSong.Data.UnitOfWork.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRecordLabelRepository RecordLabels { get; } 
    IStudioRepository Studios { get; } 
    ICountryRepository Countries{ get; }
    ISongRepository Songs { get; }
    IMemberRepository Members { get; }
    IBirthPlaceRepository BirthPlaces { get; }
    IArtistRepository Artists { get;  }
    IAlbumRepository Albums { get;  }
    IAlbumSongRepository AlbumSongs { get; }
    IAccountRepository Accounts { get; }
    Task<int> Complete();
}