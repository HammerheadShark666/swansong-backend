using System;

namespace SwanSong.Helper;

public class EmailMessages
{
    public static string VerifyEmailAddressEmail(string baseUrl, string verificationToken)
    {
        var verifyUrl = String.Format(Constants.VerifyUrl, baseUrl, verificationToken);

        string email = $@"<html xmlns='http://www.w3.org/1999/xhtml'>
                        <head>
                            <title></title>
                        </head>
                        <body>
                            <div width='100%' height='300px' style='background-color:aliceblue;padding-bottom:50px'>
                                <table width='100%' style='background-color:aliceblue;'>       
                                   <tr>       
                                       <td width='100%'; style='padding-left:20%'>
                                          <h2 style = 'padding-top:50px'>SwanSong</h2>   
                                       </td>   
                                    </tr>
                                   <tr>        
                                        <td width='100%'; style='padding-left:23%'>        
                                            <h3>
                                                Nearly there. <br />
                                                Let's confirm your email address.
                                            </h3>         
                                        </td>         
                                    </tr>         
                                    <tr>         
                                        <td width='100%'; style='padding-left:23%'>        
                                              <p style='color:darkcyan;'>By clicking on the following link, you are confirming your email address.</p>
                                        </td>              
                                    </tr>  
                                    <tr>         
                                        <td style='padding-top: 50px; text-align: center;' width='100%'; height='100%'>
                                            <a style='color:crimson;' href='{verifyUrl}'>Confirm Email Address</a>
                                        </td>
                                    </tr>
                             </table>   
                             <br/>
                             <br/>
                           </div>
                        </body>
                    </html>";

        email = email.Replace("{verifyUrl}", verifyUrl);

        return email;
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

        string email = $@"<html xmlns='http://www.w3.org/1999/xhtml'>
                        <head>
                            <title></title>
                        </head>
                        <body>
                            <div width='100%' height='300px' style='background-color:aliceblue;padding-bottom:50px'>
                                <table width='100%' style='background-color:aliceblue;'>       
                                   <tr>       
                                       <td width='100%'; style='padding-left:20%'>
                                          <h2 style = 'padding-top:50px'>SwanSong</h2>   
                                       </td>   
                                    </tr>
                                   <tr>        
                                        <td width='100%'; style='padding-left:23%'>        
                                            <h3>
                                                Reset Password Email
                                            </h3>         
                                        </td>         
                                    </tr>         
                                    <tr>         
                                        <td width='100%'; style='padding-left:23%'>        
                                              <p style='color:darkcyan;'>Please click the below link to reset your password, the link will be valid for 1 day.</p>
                                        </td>              
                                    </tr>  
                                    <tr>         
                                        <td style='padding-top: 10px; text-align: center;' width='100%'; height='100%'>
                                            <a style='color:crimson;' href='{resetUrl}'>Confirm Password Reset</a>
                                        </td>
                                    </tr>
                             </table>   
                             <br/>
                             <br/>
                           </div>
                        </body>
                    </html>";

        email = email.Replace("{resetUrl}", resetUrl);

        return email; 
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