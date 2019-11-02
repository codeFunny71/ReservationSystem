using System;
using Microsoft.EntityFrameworkCore;

namespace ReservationSystem.Data
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options)
            : base(options)
        {
        }

        public DbSet<ReservationSystem.Models.Reservation> Reservation { get; set; }
    }
}
