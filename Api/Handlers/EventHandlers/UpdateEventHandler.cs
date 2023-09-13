using MediatR;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.Event;
using WebApplication1.Api.Request.EventRequest;

namespace WebApplication1.Api.Handlers.EventHandlers
{
    public class UpdateEventHandler : IRequestHandler<UpdateEventRequest, UpdateEventResponse>
    {
        public IRepository<Event> _repository;

        public UpdateEventHandler(IRepository<Event> repository)
        {
            _repository = repository;
        }

        public async Task<UpdateEventResponse> Handle(UpdateEventRequest request, CancellationToken cancellationToken)
        {
            var res = _repository.Update(request.events);

            if (res == null)
            {
                return new UpdateEventResponse() { errorMessage = "Ошибка получения события. Список пуст!", success = true };
            }

            return new UpdateEventResponse();
        }
    }
}
