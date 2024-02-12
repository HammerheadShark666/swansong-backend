using System;

namespace SwanSong.Helper;

public class EnvironmentVariablesHelper
{
    public static string AppSettingsFrontEndBaseUrl = Environment.GetEnvironmentVariable(Constants.AppSettingsFrontEndBaseUrl);
   
    public static string JwtSettingsSercret = Environment.GetEnvironmentVariable(Constants.JwtSettingsSercret);
    public static int JwtSettingsRefreshTokenTtl = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenTtl));
    public static int JwtSettingsTokenExpiryMinutes = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsTokenExpiryMinutes));
    public static int JwtSettingsRefreshTokenExpiryDays = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenExpiryDays));
    public static int JwtSettingsPasswordTokenExpiryDays = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsPasswordTokenExpiryDays));

    public static string RegisterSenderEmail = Environment.GetEnvironmentVariable(Constants.RegisterSenderEmail);
      
    public static string SmtpGmailServer = Environment.GetEnvironmentVariable(Constants.SmtpGmailServer);
    public static int SmtpGmailPort = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.SmtpGmailPort));
    public static string SmtpGmailUsername = Environment.GetEnvironmentVariable(Constants.SmtpGmailUsername);
    public static string SmtpGmailPassword = Environment.GetEnvironmentVariable(Constants.SmtpGmailPassword);
     
    public static string AzureStorageConnectionString = Environment.GetEnvironmentVariable(Constants.AzureStorageConnectionString);
}