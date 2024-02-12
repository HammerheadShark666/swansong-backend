using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface ISongRepository
{  
    void Delete(Song song);
    Task<Song> ByIdAsync(long id);
}