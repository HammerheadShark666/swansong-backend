using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class SongRepository : ISongRepository
{
    private readonly SwanSongContext _context;

    public SongRepository(SwanSongContext context)
    {
        _context = context;
    }
     
    public void Delete(Song song)
    {
        _context.Songs.Remove(song);
    }

    public async Task<Song> ByIdAsync(long id)
    {
        return await _context.Songs.FindAsync(id);
    }
}