using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database.Entities;
using WebApplication1.Database;

namespace WebApplication1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IRepository<User> _userRepository;
        public UserController(IRepository<User> repository)
        {
            _userRepository = repository;
        }
        [HttpGet("{Get}")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userRepository.GetList();
        }
        [HttpGet]
        public async Task<ActionResult<User>> Get(int id)
        {
            return await _userRepository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody] User user)
        {
            var newUser = await _userRepository.Create(user);
            return CreatedAtAction(nameof(Get), new { newUser.id }, newUser);
        }
        [HttpPut]
        public async Task<ActionResult<User>> PutUser(int id, [FromBody] User user)
        {
            if (id != user.id)
            {
                return BadRequest();
            }
            await _userRepository.Update(user);
            return NoContent();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var userDelete = await _userRepository.Get(id);
            if (userDelete == null)
            {
                return NotFound();
            }
            await _userRepository.Delete(userDelete.id);
            return NoContent();
        }
    }
}
