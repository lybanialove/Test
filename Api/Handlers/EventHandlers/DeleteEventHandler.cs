using MediatR;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.Event;

namespace WebApplication1.Api.Handlers.EventHandlers
{
    public class DeleteEventHandler : IRequestHandler<GetEventRequest, GetEventResponse>
    {
        public IRepository<Event> _repository;

        public DeleteEventHandler(IRepository<Event> repository)
        {
            _repository = repository;
        }

        public async Task<GetEventResponse> Handle(GetEventRequest request, CancellationToken cancellationToken)
        {
            var res = await _repository.Get(request.id);

            if (res == null)
            {
                return new GetEventResponse() { errorMessage = "Ошибка удаления события. Список пуст!", success = true };
            }
            await _repository.Delete(res.id);

            return new GetEventResponse();
        }
    }
}
