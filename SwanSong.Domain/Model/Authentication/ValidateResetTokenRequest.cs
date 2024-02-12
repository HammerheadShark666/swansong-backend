using System.ComponentModel.DataAnnotations;

namespace SwanSong.Domain.Model.Authentication;

public class ValidateResetTokenRequest
{
    [Required]
    public string Token { get; set; }
}