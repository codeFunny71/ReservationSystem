using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Data;
using ReservationSystem.Models;

namespace ReservationSystem.Pages.Reservations
{
    public class IndexModel : PageModel
    {
        private readonly ReservationSystem.Data.ReservationContext _context;

        public IndexModel(ReservationSystem.Data.ReservationContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; }

        public async Task OnGetAsync()
        {
            Reservation = await _context.Reservation.ToListAsync();
        }
    }
}
