namespace SwanSong.Domain.Dto
{
    public class ProfilePasswordChangeDto : BaseDto
    {
        public int Id { get; set; }       
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string CurrentPassword { get; set; }
        public string Email { get; set; }
    }
}
