using EventManagementAPI.Data;
using EventManagementAPI.Models;
using EventManagementAPI.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var records = _context.User.ToList();
            return records;
        }

        public User GetUserById(int id)
        {
            var record = _context.User.FirstOrDefault(x => x.Id == id);
            return record;
        }

        public User AddUser(User u)
        {
            if (u != null)
            {
                _context.User.Add(u);
                _context.SaveChanges();
                return u;
            }
            return null;
        }

        public User UpdateUser(User u)
        {
            _context.Entry(u).State = EntityState.Modified;
            _context.SaveChanges();
            return u;
        }

        public User DeleteUser(int id)
        {
            var record = _context.User.FirstOrDefault(x => x.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }
    }
}
