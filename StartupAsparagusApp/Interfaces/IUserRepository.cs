using StartupAsparagusApp.Models;

namespace StartupAsparagusApp.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        Task SaveAsync(User user);
    }
}
