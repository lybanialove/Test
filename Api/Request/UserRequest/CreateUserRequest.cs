using MediatR;
using WebApplication1.Api.Response;

namespace WebApplication1.Api.Request.UserRequest
{
    public class CreateUserRequest : IRequest<UserResponse>
    {
        public string UserName { get; set; }
        public List<Database.Entities.Event> Events { get; set; }
    }
}
