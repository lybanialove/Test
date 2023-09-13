using MediatR;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.User;

namespace WebApplication1.Api.Handlers.UserHandlers
{
    public class GetUserHandler : IRequestHandler<GetUserRequest, UserResponse>
    {
        public IRepository<User> _repository;

        public GetUserHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<UserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var res = await _repository.Get(int.Parse(request.id));

            if (res == null)
            {
                return new UserResponse() { errorMessage = "Ошибка получения пользователя. Список пуст!", success = true };
            }
            return new UserResponse();
        }
    }

}
