using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Models
{
    public class Role
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Roles { get; set; }
       
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
