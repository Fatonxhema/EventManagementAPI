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
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet("getall")]
        public IEnumerable<Event> GetAllEvents()
        {
            return _eventService.GetAllEvents();
        }

        [HttpGet("get/{id}")]
        public Event GetEventById(int id)
        {
            return _eventService.GetEventById(id);
        }

        [HttpPost("add")]
        public Event AddEvent(Event e)
        {
            return _eventService.AddEvent(e);
        }

        [HttpPut("edit")]
        public Event UpdateEvent(Event e)
        {
            return _eventService.UpdateEvent(e);
        }

        [HttpDelete("delete/{id}")]
        public Event DeleteEvent(int id)
        {
            return _eventService.DeleteEvent(id);
        }
    }
}
