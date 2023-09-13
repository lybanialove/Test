using MediatR;
using WebApplication1.Api.Response;

namespace WebApplication1.Api.Request.User
{
    public class GetUserRequest : IRequest<UserResponse>
    {
        public string UserName { get; set; }
        public string id { get; set; }
    }
}
