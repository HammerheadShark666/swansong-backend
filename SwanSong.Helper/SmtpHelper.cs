using MailKit.Net.Smtp;
using MimeKit;

namespace SwanSong.Helper;

public class SmtpHelper
{
    public static void SendEmail(string recipientAddress, string subject, string messageBody)
    {
        var email = new MimeMessage()
        {
            Subject = subject,
            Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = messageBody
            }
        };

        email.From.Add(new MailboxAddress("Sender Name", EnvironmentVariablesHelper.RegisterSenderEmail));
        email.To.Add(new MailboxAddress("Receiver Name", recipientAddress));
        
        using (var smtp = new SmtpClient())
        {
            smtp.Connect(EnvironmentVariablesHelper.SmtpGmailServer, EnvironmentVariablesHelper.SmtpGmailPort, false);             
            smtp.Authenticate(EnvironmentVariablesHelper.SmtpGmailUsername, EnvironmentVariablesHelper.SmtpGmailPassword);
            smtp.Send(email);
            smtp.Disconnect(true);
        } 
    }
}
