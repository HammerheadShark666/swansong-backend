using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(SwanSongContext context) : base(context) { }

        public async Task<List<Album>> GetAllAsync(int pageNumber, int pageSize)
        {
            return await _context.Albums
                                 .OrderBy(a => a.Name)
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        }

        public async Task<List<Album>> GetRandomAsync(int numberOfAlbums)
        {
            return await _context.Albums
                .Include(a => a.Artist)
                .Include(s => s.AlbumSongs).ThenInclude(t => t.Song)
                .OrderByDescending(x => Guid.NewGuid()).Take(numberOfAlbums).ToListAsync(); 
        }

        public async Task<long> CountAsync()
        {
            return await _context.Albums.CountAsync();
        }

        public async Task<IEnumerable<Album>> SearchByNameAsync(string criteria)
        {
            return await (from album in _context.Albums
                          join label in _context.RecordLabels on album.LabelId equals label.Id into lbl
                          from label in lbl.DefaultIfEmpty()
                          where album.Name.ToUpper().Contains(criteria.ToUpper())
                          select album).ToListAsync();
        }

        public async Task<IEnumerable<Album>> SearchByLetterAsync(string letter)
        {
            return await (from album in _context.Albums
                          where album.Name.ToUpper().Substring(0, 1).Equals(letter.ToUpper())
                          select album).ToListAsync();
        }

        public async Task<IEnumerable<Album>> GetAlbumsForArtistAsync(long artistId)
        {
            return await (from album in _context.Albums
                          where album.ArtistId.Equals(artistId)
                          select album).ToListAsync();
        }

        public async Task<Album> GetAsync(long id)
        {
            var album = await _context.Albums
                                .Include(e => e.Artist)
                                .Include(m => m.Label)
                                .Include(r => r.Studio)
                                .Include(s => s.AlbumSongs).ThenInclude(t => t.Song)
                                .Where(a => a.Id.Equals(id))
                                .FirstOrDefaultAsync();

            if (album != null)
                album.AlbumSongs = album.AlbumSongs.OrderBy(t => t.Side).ThenBy(t => t.Order).ToList();

            return album;
        }

        public async Task<Album> GetAsync(long artistId, string name)
        {
            return await _context.Albums
                                   .Where(a => a.Name.Equals(name)
                                        && a.ArtistId.Equals(artistId))
                                   .FirstOrDefaultAsync();
        }

        public async Task<Album> GetAsync(long id, long artistId, string name)
        {
            return await _context.Albums
                                   .Where(a => a.Name.Equals(name)
                                        && a.ArtistId.Equals(artistId)
                                            && a.Id != id)
                                   .FirstOrDefaultAsync();
        }

        public async Task<Album> UpdateAlbumPhotoAsync(long id, string filename)
        {
            Album album = await GetAsync(id);

            album.Photo = filename;
            _context.SaveChanges();

            return album;
        }

        public async Task<bool> ExistsAsync(string name)
        {
            return await _context.Albums
                                    .Where(a => a.Name.Equals(name)).AnyAsync();
        }

        public async Task<bool> ExistsAsync(long id, string name)
        {
            return await _context.Albums
                                   .Where(a => a.Name.Equals(name)
                                        && !a.Id.Equals(id))
                                   .AnyAsync();
        }
    }
}