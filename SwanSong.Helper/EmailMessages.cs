using System;

namespace SwanSong.Helper
{
    public class EmailMessages
    {
        public static string VerifyEmailAddressEmail(string baseUrl, string verificationToken)
        {
            var verifyUrl = String.Format(Constants.VerifyUrl, baseUrl, verificationToken);

            return $@"<h4>Verify Email</h4>
                      <p>Thanks for registering!</p>
                      <p>Please click the below link to verify your email address:</p>
                      <p><a href=""{verifyUrl}"">{verifyUrl}</a></p>";
        }

        public static string VerifyEmailAddressNoVerifyUrlEmail(string verificationToken)
        {
            return $@"<h4>Verify Email</h4>
                      <p>Thanks for registering!</p>
                      <p>Please use the below token to verify your email address with the <code>/accounts/verify-email</code> api route:</p>
                      <p><code>{verificationToken}</code></p>";
        }

        public static string PasswordResetEmail(string baseUrl, string passwordResetToken)
        {
            var resetUrl = String.Format(Constants.ResetUrl, baseUrl, passwordResetToken);

            return $@"<h4>Reset Password Email</h4>
                      <p>Please click the below link to reset your password, the link will be valid for 1 day:</p>
                      <p><a href=""{resetUrl}"">{resetUrl}</a></p>";
        }

        public static string PasswordResetNoResetUrlEmail(string passwordResetToken)
        {
            return $@"<h4>Reset Password Email</h4>
                      <p>Please use the below token to reset your password with the <code>/accounts/reset-password</code> api route:</p>
                      <p><code>{passwordResetToken}</code></p>";
        }

        public static string AlreadyRegisteredEmail(string baseUrl)
        {
            return $@"<h4>Email Already Registered</h4>
                      <p>If you don't know your password please visit the <a href=""{baseUrl}/forgot-password"">forgot password</a> page.</p>";
        }    
         
        public static string AlreadyRegisteredNoBaseUrlEmail()
        {
            return $@"<h4>Email Already Registered</h4>
                      <p>If you don't know your password you can reset it via the <code>/forgot-password</code> api route.</p>";
        }    
    }
}
