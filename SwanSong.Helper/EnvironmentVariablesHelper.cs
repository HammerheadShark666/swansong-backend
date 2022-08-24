using System;

namespace SwanSong.Helper
{
    public class EnvironmentVariablesHelper
    {
        public static string AppSettingsFrontEndBaseUrl()
        {
            return Environment.GetEnvironmentVariable(Constants.AppSettingsFrontEndBaseUrl);
        }

        public static string SendGridApiKey()
        {
            return Environment.GetEnvironmentVariable(Constants.SendGridApiKey);
        }

        public static string SendGridDefaultFromEmail()
        {
            return Environment.GetEnvironmentVariable(Constants.SendGridDefaultFromEmail);
        }

        public static string AzureStorageConnectionString()
        {
            return Environment.GetEnvironmentVariable(Constants.AzureStorageConnectionString);
        }

        public static string JwtSettingsSercret()
        {
            return Environment.GetEnvironmentVariable(Constants.JwtSettingsSercret);
        }

        public static int JwtSettingsRefreshTokenTtl()
        {
            return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenTtl));
        }

        public static int JwtSettingsTokenExpiryMinutes()
        {
            return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsTokenExpiryMinutes));
        }

        public static int JwtSettingsRefreshTokenExpiryDays()
        {
            return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenExpiryDays));
        }

        public static int JwtSettingsPasswordTokenExpiryDays()
        {
            return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsPasswordTokenExpiryDays));
        } 
    }
}
