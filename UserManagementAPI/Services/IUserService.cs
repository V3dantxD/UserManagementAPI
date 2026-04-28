using UserManagementAPI.DTOs;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services;

public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
    User CreateUser(CreateUserRequest request);
    bool UpdateUser(int id, UpdateUserRequest request);
    bool DeleteUser(int id);
}
