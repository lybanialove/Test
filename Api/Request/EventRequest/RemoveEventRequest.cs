using MediatR;
using WebApplication1.Api.Response;

namespace WebApplication1.Api.Request.EventRequest
{
    public class RemoveEventRequest : IRequest<RemoveEventResponse>
    {
        public int id { get; set; }
    }
}
