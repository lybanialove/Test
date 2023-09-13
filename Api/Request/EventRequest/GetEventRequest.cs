using MediatR;
using WebApplication1.Api.Response;

namespace WebApplication1.Api.Request.Event
{
    public class GetEventRequest : IRequest<GetEventResponse>
    {
        public int id { get; set; }
    }
}
