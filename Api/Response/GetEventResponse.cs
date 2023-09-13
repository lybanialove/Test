using WebApplication1.Api.Response;
using WebApplication1.Database.Entities;

namespace WebApplication1
{
    public class GetEventResponse : BaseResponse
    {
        public Event events {  get; set; }
    }
}
