using EventManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Services.IServices
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);

        User AddUser(User u);

        User UpdateUser(User u);

        User DeleteUser(int id);
    }
}
