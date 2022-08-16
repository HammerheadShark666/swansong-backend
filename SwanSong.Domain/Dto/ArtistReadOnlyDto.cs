namespace SwanSong.Domain.Dto
{
    public class ArtistReadOnlyDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? FormationYear { get; set; }
        public string Photo { get; set; }
    }
}
