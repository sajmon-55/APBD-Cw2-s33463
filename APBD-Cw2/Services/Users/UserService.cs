using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Users;

public class UserService : IUserService
{
    private readonly List<User> _users = [];

    public void AddUser(User user)
    {
        _users.Add(user);
    }
}