using Microsoft.EntityFrameworkCore;
using StartupAsparagusApp.Data;
using StartupAsparagusApp.Interfaces;
using StartupAsparagusApp.Models;

namespace StartupAsparagusApp.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDataContext context;
        public UserRepository(UserDataContext dbcontext)
        {
            context = dbcontext;
        }
        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }
        public async Task SaveAsync(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }
    }
}
