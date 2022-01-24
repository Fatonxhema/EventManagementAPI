using EventManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Services.IServices
{
    public interface IEventService
    {
        IEnumerable<Event> GetAllEvents();

        Event GetEventById(int id);

        Event AddEvent(Event e);

        Event UpdateEvent(Event e);

        Event DeleteEvent(int id);
    }
}
