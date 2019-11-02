using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        //// Requires using Microsoft.AspNetCore.Mvc.Rendering;
        //public SelectList Boats { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string BoatType { get; set; }

        public async Task OnGetAsync()
        {
            var reservations = from m in _context.Reservation
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                reservations = reservations.Where(s => s.Name.Contains(SearchString));
            }
            Reservation = await reservations.ToListAsync();
        }
    }
}
