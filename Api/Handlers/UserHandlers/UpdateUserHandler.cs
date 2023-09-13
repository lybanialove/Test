using MediatR;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.User;

namespace WebApplication1.Api.Handlers.UserHandlers
{
    public class UpdateUserHandler : IRequestHandler<GetUserRequest, UserResponse>
    {
        public IRepository<User> _repository;

        public UpdateUserHandler(IRepository<User> repository)
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
            await _repository.Update(res);

            return new UserResponse();
        }
    }
}
