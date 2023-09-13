namespace WebApplication1.Api.Response
{
    public class BaseResponse
    {
        public bool success { get; set; } = false;
        public string errorMessage { get; set; }
    }
}
