using WebApplication1.Database.Entities;

namespace WebApplication1.Api.Response
{
    public class GetListEventResponse: BaseResponse
    {
        public List<Event> events { get; set; }
    }
}
