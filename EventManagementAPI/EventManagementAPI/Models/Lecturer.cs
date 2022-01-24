using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Models
{
    public class Lecturer
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(70)]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }

        public Event Event { get; set; }
    }
}
