using System.ComponentModel.DataAnnotations;

namespace SwanSong.Domain.Model.Authentication;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}