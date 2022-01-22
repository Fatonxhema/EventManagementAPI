using EventManagementAPI.Data;
using EventManagementAPI.Models;
using EventManagementAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Services
{
    public class EventService : IEventService
    {
        private readonly DataContext _context;

        public EventService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            var records = _context.Event.ToList();
            return records;
        }
    }
}
