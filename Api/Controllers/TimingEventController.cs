using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.Database.Entities;

namespace WebApplication1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimingEventController : ControllerBase
    {
        IRepository<Event> _eventRepository;

        public TimingEventController(IRepository<Event> repository)
        {
            _eventRepository = repository;
        }
        [HttpPost]
        public async Task<ActionResult<DateTime>> TimingEvent(int id)
        {
            var asd = _eventRepository.Get(id).Result;
            if (asd == null)
            {
                return BadRequest();
            }
            var most = asd.DateTimes.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            return most;
        }
    }
}
