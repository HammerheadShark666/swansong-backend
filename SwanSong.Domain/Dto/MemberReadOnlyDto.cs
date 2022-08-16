namespace SwanSong.Domain.Dto
{
    public class MemberReadOnlyDto
    {
        public long Id { get; set; }         
        public string StageName { get; set; }
        public string Photo { get; set; } 
        public string ArtistName { get; set; }
    }
}
