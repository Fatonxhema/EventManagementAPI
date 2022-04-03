using EventManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Event> Event { get; set; }
        public DbSet<Lecturer> Lecturer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
