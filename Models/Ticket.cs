using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLDemo.Models
{
    public class Ticket
    {
        // Properties
        public int ID { get; set; }
        public string TicketTitle { get; set; }
        public string TicketText { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }

        // Navigation properties
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }

        public Ticket()
        {
            TimeCreated = DateTime.Now;
            TimeUpdated = TimeCreated;
            TicketTitle = "Untitled";
        }
    }
}
