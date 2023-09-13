using WebApplication1.Database.Entities;
using WebApplication1.Database;
using MediatR;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.User;

namespace WebApplication1.Api.Handlers.UserHandlers
{
    public class GetListUserHandler : IRequestHandler<UserRequest, UserResponse>
    {
        public IRepository<User> _repository;

        public GetListUserHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<UserResponse> Handle(UserRequest request, CancellationToken cancellationToken)
        {
            var res = await _repository.GetList();
            if (res == null)
            {
                return new UserResponse() { errorMessage = "Ошибка получения пользователей. Список пуст!" };
            }
            return new UserResponse();
        }
    }
}
