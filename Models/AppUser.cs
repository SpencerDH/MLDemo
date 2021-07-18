using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MLDemo.Models
{
    public class AppUser : IdentityUser
    {
        // Properties
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Institution { get; set; }

        // Navigation properties
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
