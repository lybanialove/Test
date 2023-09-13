using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database.Entities;
using WebApplication1.Database;
using MediatR;
using WebApplication1.Api.Request.Event;
using WebApplication1.Api.Response;
using WebApplication1.Api.Request.EventRequest;

namespace WebApplication1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        readonly IMediator _mediator;

        public EventController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("Получить все события")]
        public async Task<IActionResult> GetList([FromQuery] GetListEventRequest request)
        {
            var resp = await _mediator.Send(request);
            if (!resp.success)
            {
                return Ok(resp);
            }
            else
            {
                return BadRequest(resp);
            } 
        }
        [HttpGet("Получить событие по уникальному коду")]
        public async Task<IActionResult> Get([FromQuery]GetEventRequest request)
        {
            var resp = await _mediator.Send(request);
            if (!resp.success)
            {
                return Ok(resp);
            }
            else
            {
                return BadRequest(resp);
            }
        }
        [HttpPost("Создать событие")]
        public async Task<IActionResult> PostEvent([FromBody]CreateEventRequest request)
        {
            var resp = await _mediator.Send(request);
            if (!resp.success)
            {
                return Ok(resp);
            }
            else
            {
                Console.WriteLine("asdasdasd");
                return BadRequest(resp);
            }
        }
        [HttpPut("Изменить событие")]
        public async Task<IActionResult> PutUser([FromQuery] UpdateEventRequest request)
        {
            var resp = await _mediator.Send(request);
            if (!resp.success)
            {
                return Ok(resp);
            }
            else
            {
                return BadRequest(resp);
            }
        }
        [HttpDelete("Удалить событие")]
        public async Task<IActionResult> Delete([FromQuery] RemoveEventRequest request)
        {
            var resp = await _mediator.Send(request);
            if (!resp.success)
            {
                return Ok(resp);
            }
            else
            {
                return BadRequest(resp);
            }
        }
    }
}
