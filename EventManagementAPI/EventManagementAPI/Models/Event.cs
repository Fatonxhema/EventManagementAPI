using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Models
{
    public class Event
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Campus { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(25)]
        public string Room { get; set; }
        public string Description { get; set; }
    }
}
