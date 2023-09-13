using MediatR;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.User;
using WebApplication1.Api.Request.UserRequest;

namespace WebApplication1.Api.Handlers.UserHandlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, UserResponse>
    {
        public IRepository<User> _repository;

        public CreateUserHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<UserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            if (request.UserName == null)
            {
                return new UserResponse() { errorMessage = "Введите имя пользователя!", success = true };
            }
            User _user = new User();
            _user.name = request.UserName;
            _user.events = request.Events;
            return new UserResponse() ;
        }
    }
}

