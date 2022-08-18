using System;

namespace SwanSong.Domain.Dto
{
    public class AlbumReadOnlyDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ArtistName { get; set; }
        public string Photo { get; set; }
        public string Length { get; set; }
        public string Tracks { get; set; }
    }
}
