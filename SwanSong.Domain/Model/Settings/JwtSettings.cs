namespace SwanSong.Domain.Model.Settings
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public int RefreshTokenTTL { get; set; }
        public int TokenExpiryMinutes { get; set; }
        public int RefreshTokenExpiryDays { get; set; }
        public int ResetPasswordTokenExpiryDays { get; set; }
    }
}
