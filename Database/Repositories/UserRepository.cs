using Microsoft.EntityFrameworkCore;
using WebApplication1.Database.Context;
using WebApplication1.Database.Entities;
using WebApplication1.Database;

namespace WebApplication1.Database.Repositories
{
    public class UserRepository : IRepository<User>

    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<User> Create(User user)
        {
            _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            return;
        }

        public async Task<IEnumerable<User>> GetList()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
