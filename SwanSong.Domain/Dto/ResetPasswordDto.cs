namespace SwanSong.Domain.Dto
{
    public class ResetPasswordDto : BaseDto
    {
        public string Token { get; set; }         
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
