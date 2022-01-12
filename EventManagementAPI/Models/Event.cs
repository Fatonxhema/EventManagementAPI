using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Campus { get; set; }
        public DateTime Date { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
    }
}
