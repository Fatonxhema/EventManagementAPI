using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Models
{
    public class Role
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Roles { get; set; }
    }
}
