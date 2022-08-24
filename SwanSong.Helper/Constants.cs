namespace SwanSong.Helper
{
    public static class Constants
    {
        public const string DefaultImage = "music-note.jpg"; 
        public const string VerifyUrl = "{0}/register/verify-email/{1}";
        public const string ResetUrl = "{0}/reset-password/{1}";
        public const string AlreadyReadyRegisteredUrl = "{0}/forgot-password";

        public const string AzureStorageContainerAlbums = "albums";
        public const string AzureStorageContainerArtists = "artists";
        public const string AzureStorageContainerMembers = "members";

        public static string DefaultArtistPhotoFileName = "default-artist-image.jpg";
        public static string DefaultAlbumPhotoFileName = "default-album-image.jpg";
        public static string DefaultMemberPhotoFileName = "default-member-image.jpg";

        public const string FileExtensionJpg = "jpg";

        public const string DatabaseConnectionString = "SQLAZURECONNSTR_SWANSONG";
        public const string AzureStorageConnectionString = "SWANSONG_AZURE_STORAGE_CONNECTION_STRING";
        public const string SendGridApiKey = "SWANSONG_SENDGRID_CONNECTION_STRING";

        public const string JwtSettingsSercret = "SWANSONG_JWT_SETTINGS_SECRET";
        public const string JwtSettingsRefreshTokenTtl = "SWANSONG_JWT_SETTINGS_REFRESH_TOKEN_TTL";
        public const string JwtSettingsTokenExpiryMinutes = "SWANSONG_JWT_SETTINGS_TOKEN_EXPIRY_MINUTES";
        public const string JwtSettingsRefreshTokenExpiryDays = "SWANSONG_JWT_SETTINGS_REFRESH_TOKEN_EXPIRY_DAYS";
        public const string JwtSettingsPasswordTokenExpiryDays = "SWANSONG_JWT_SETTINGS_RESET_PASSWORD_TOKEN_EXPIRY_DAYS";
    }
}