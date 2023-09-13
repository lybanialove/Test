using MediatR;
using WebApplication1.Api.Response;
using WebApplication1.Database.Entities;

namespace WebApplication1.Api
{
    public class CreateEventRequest : IRequest<CreateEventResponse>
    {
        public string name { get; set; }
        public List<User> user { get; set; }
        public List<DateTime> DateTimes { get; set; }
    }
}
