using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(15)]
        public string Campus { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(15)]
        public string Room { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [ForeignKey("Lecturer")]
        public ICollection<Lecturer> Lecturers { get; set; }
    }
}
