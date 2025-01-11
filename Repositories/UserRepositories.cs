using System.Data;
using Dapper;
using MyWebApi.Models;

namespace MyWebApi.Repositories;
public class UserRepository : IUserRepository
{
    private readonly IDbConnection _db;

    public UserRepository(IDbConnection db)
    {
        _db = db;
    }

    public async Task<User> GetUserByUsernameAsync(string username)
    {
        var sql = "SELECT * FROM Users WHERE Username = @Username";
        return await _db.QuerySingleOrDefaultAsync<User>(sql, new { Username = username });
    }

    public async Task AddUserAsync(User user)
    {
        var sql = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
        await _db.ExecuteAsync(sql, user);
    }
}
