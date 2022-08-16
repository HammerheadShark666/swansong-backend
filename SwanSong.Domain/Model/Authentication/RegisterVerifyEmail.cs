using System.ComponentModel.DataAnnotations;

namespace SwanSong.Domain.Model.Authentication
{
    public class RegisterVerifyEmail
    {        
        public string Token { get; set; }
    }
}