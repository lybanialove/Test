using MediatR;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.Event;

namespace WebApplication1.Api.Handlers.EventHandlers
{
    public class GetListEventHandler : IRequestHandler<GetListEventRequest, GetListEventResponse>
    {
        public IRepository<Event> _repository;

        public GetListEventHandler(IRepository<Event> repository)
        {
            _repository = repository;
        }

        public async Task<GetListEventResponse> Handle(GetListEventRequest request, CancellationToken cancellationToken)
        {
            var res = await _repository.GetList();
            
            return new GetListEventResponse();
        }
    }
}
