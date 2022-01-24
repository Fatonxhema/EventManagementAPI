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

        public Event GetEventById(int id)
        {
            var record = _context.Event.FirstOrDefault(x => x.Id == id);
            return record;
        }

        public Event AddEvent(Event e)
        {
            if(e != null)
            {
                _context.Event.Add(e);
                _context.SaveChanges();
                return e;
            }
            return null;
        }

        public Event UpdateEvent(Event e)
        {
            _context.Entry(e).State = EntityState.Modified;
            _context.SaveChanges();
            return e;
        }

        public Event DeleteEvent(int id)
        {
            var record = _context.Event.FirstOrDefault(x => x.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }
    }
}
