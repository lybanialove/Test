using Microsoft.EntityFrameworkCore;
using WebApplication1.Database.Context;
using WebApplication1.Database.Entities;
using WebApplication1.Database;

namespace WebApplication1.Database.Repositories
{
    public class EventRepository : IRepository<Event>

    {
        private readonly ApplicationContext _context;

        public EventRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Event> Create(Event eventt)
        {
            _context.Events.AddAsync(eventt);
            await _context.SaveChangesAsync();
            return eventt;
        }

        public async Task Delete(int id)
        {
            var eventToDelete = await _context.Events.FindAsync(id);
            if (eventToDelete != null)
            {
                _context.Events.Remove(eventToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            return;
        }

        public async Task<IEnumerable<Event>> GetList()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> Get(int id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task Update(Event eventt)
        {
            _context.Entry(eventt).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
