namespace SwanSong.Domain.Model.Authentication
{
    public class JwtRefreshToken
    {
        public User User { get; set; }
        public bool IsAuthenticated { get; set; }
        public string JwtToken { get; set; }
        public string RefreshToken { get; set; }
        public string Role { get; set; }
    }
}
