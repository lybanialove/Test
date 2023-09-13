using MediatR;
using WebApplication1.Api.Response;
using WebApplication1.Database.Entities;

namespace WebApplication1
{
    public class UpdateEventRequest : IRequest<UpdateEventResponse>
    {
        public Event events {  get; set; }
    }
}
