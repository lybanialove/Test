using MediatR;
using WebApplication1.Database;
using WebApplication1.Database.Entities;

using WebApplication1.Api.Response;


namespace WebApplication1.Api.Handlers.EventHandlers
{
    public class CreateEventHandler : IRequestHandler<CreateEventRequest, CreateEventResponse>
    {
        public IRepository<Event> _repository;

        public CreateEventHandler(IRepository<Event> repository)
        {
            _repository = repository;
        }

        public async Task<CreateEventResponse> Handle(CreateEventRequest request, CancellationToken cancellationToken)
        {
            foreach (var time in request.DateTimes)
            {
                if (time.ToUniversalTime() < DateTime.UtcNow)
                {
                    return new CreateEventResponse() { errorMessage = "Введена неверная дата!", success = true };
                }
            }
            Event _event = new Event(); 
            _event.DateTimes = request.DateTimes;  
            _event.name = request.name;
            _event.user = request.user;
            _event.unique = Guid.NewGuid();
            await _repository.Create(_event);
            return new CreateEventResponse() ;
        }
    }
}
