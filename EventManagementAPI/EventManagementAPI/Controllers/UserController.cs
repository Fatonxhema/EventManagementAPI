using EventManagementAPI.Models;
using EventManagementAPI.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IEnumerable<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("get/{id}")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost("add")]
        public User AddUser(User u)
        {
            return _userService.AddUser(u);
        }

        [HttpPut("edit")]
        public User UpdateUser(User u)
        {
            return _userService.UpdateUser(u);
        }

        [HttpDelete("delete/{id}")]
        public User DeleteUser(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
