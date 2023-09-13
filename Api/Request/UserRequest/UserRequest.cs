using MediatR;
using WebApplication1.Api.Response;

namespace WebApplication1.Api.Request.User
{
    public class UserRequest : IRequest<UserResponse>
    {
        public string userName { get; set; }
    }
}
