using UserManagementAPI.DTOs;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services;

public class UserService : IUserService
{
    private readonly List<User> _users =
    [
        new User { Id = 1, Name = "Aarav Patel", Email = "aarav.patel@example.com", Role = "HR Manager" },
        new User { Id = 2, Name = "Meera Shah", Email = "meera.shah@example.com", Role = "IT Admin" }
    ];

    private int _nextId = 3;

    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }

    public User? GetUserById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }

    public User CreateUser(CreateUserRequest request)
    {
        var user = new User
        {
            Id = _nextId++,
            Name = request.Name,
            Email = request.Email,
            Role = request.Role
        };

        _users.Add(user);
        return user;
    }

    public bool UpdateUser(int id, UpdateUserRequest request)
    {
        var existingUser = GetUserById(id);

        if (existingUser is null)
        {
            return false;
        }

        existingUser.Name = request.Name;
        existingUser.Email = request.Email;
        existingUser.Role = request.Role;

        return true;
    }

    public bool DeleteUser(int id)
    {
        var user = GetUserById(id);

        if (user is null)
        {
            return false;
        }

        _users.Remove(user);
        return true;
    }
}
