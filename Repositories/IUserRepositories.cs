using MyWebApi.Models;

namespace MyWebApi.Repositories;
public interface IUserRepository
{
    Task<User> GetUserByUsernameAsync(string username);
    Task AddUserAsync(User user);
}
