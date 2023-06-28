using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Namespace;
public class UserService : IUserService
{
    private readonly List<object> _users = new();

    public UserService()
    {

    }

    public List<object> CreateUser(Users users)
    {
        _users.Add(users);
        return _users;
    }
}
