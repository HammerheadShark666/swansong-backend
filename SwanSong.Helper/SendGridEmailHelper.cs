using SendGrid;
using SendGrid.Helpers.Mail;
using SwanSong.Domain.Model.Settings;
using System;

namespace SwanSong.Helper
{
    public class SendGridEmailHelper
    {
        public async static void SendEmail(SendGridSettings sendGridSettings, string to, string subject, string html, string from = null)
        {            
            var msg = MailHelper.CreateSingleEmail(new EmailAddress(sendGridSettings.EmailFrom), 
                                                   new EmailAddress(to), 
                                                   subject, "", html);

            var client = new SendGridClient(Environment.GetEnvironmentVariable(Constants.SendGridApiKey));
            var response = await client.SendEmailAsync(msg);
        } 
    }
}
