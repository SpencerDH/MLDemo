using Microsoft.AspNetCore.Mvc;
using MLDemo.Data;
using MLDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace MLDemo.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TicketsController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Get tickets
            var ticketsList = await _context.Tickets
                .Include(t => t.AppUser)
                .ToListAsync();


            return View(ticketsList);
        }

        public async Task<IActionResult> CreateTicket(string ticketText)
        {
            // Get current user
            // var currentUser = await _userManager.GetUserAsync(User);

            // Create new ticket from provided text
            Ticket newTicket = new Ticket
            {
                TicketText = ticketText
            };

            // Save the new ticket
            _context.Add(newTicket);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
