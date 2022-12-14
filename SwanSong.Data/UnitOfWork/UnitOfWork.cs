using SwanSong.Data.Repository;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SwanSongContext _context;
        public IRecordLabelRepository RecordLabels { get; private set; }
        public IStudioRepository Studios { get; private set; } 
        public ICountryRepository Countries { get; private set; }
        public ISongRepository Songs { get; private set; }
        public IMemberRepository Members { get; private set; }
        public IBirthPlaceRepository BirthPlaces { get; private set; }
        public IArtistRepository Artists { get; private set; }
        public IAlbumRepository Albums { get; private set; }
        public IAlbumSongRepository AlbumSongs { get; private set; }
        public IAccountRepository Accounts { get; private set; }

        public UnitOfWork(SwanSongContext context)
        {
            _context = context;
            RecordLabels = new RecordLabelRepository(_context);
            Studios = new StudioRepository(_context); 
            Countries = new CountryRepository(_context);
            Songs = new SongRepository(_context);
            Members = new MemberRepository(_context);
            BirthPlaces = new BirthPlaceRepository(_context);
            Artists = new ArtistRepository(_context);
            Albums = new AlbumRepository(_context);
            AlbumSongs = new AlbumSongRepository(_context);
            Accounts = new AccountRepository(_context);
        }        
        
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        { 
        }
    }
}