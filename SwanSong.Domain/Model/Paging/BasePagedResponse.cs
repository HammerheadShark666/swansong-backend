namespace SwanSong.Domain.Model.Paging
{
    public class BasePagedResponse<T>
    {
        public BasePagedResponse()
        {
        }
        public BasePagedResponse(T data)
        {
            Succeeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }
        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
        public string Message { get; set; }
    }
}
