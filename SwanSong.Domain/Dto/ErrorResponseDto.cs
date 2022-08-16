namespace SwanSong.Domain.Dto
{
    public class ErrorResponseDto
    {
        public string message { get; set; }
        public ErrorResponseDto(string message)
        {
            this.message = message;
        }
    }
}
