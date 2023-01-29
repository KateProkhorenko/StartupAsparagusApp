using Microsoft.EntityFrameworkCore;
using StartupAsparagusApp.Models;

namespace StartupAsparagusApp.Data
{
    public class UserDataContext : DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options) 
                                : base(options) { }
        public DbSet<User> Users => Set <User>();
    }
}
