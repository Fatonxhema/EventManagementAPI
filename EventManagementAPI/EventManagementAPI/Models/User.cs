using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
