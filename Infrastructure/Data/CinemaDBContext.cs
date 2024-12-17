using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CinemaDBContext : DbContext
    {
        public CinemaDBContext(DbContextOptions options) : base(options) {}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<ReservedSeat> ReservedSeats { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReservationHistory> ReservationsHistory { get; set; }
        public DbSet<ReservedSeatHistory> ReservedSeatsHistory { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservedSeat>()
                .HasKey(rs => new
                {
                    rs.ScreeningID,
                    rs.SeatID,
                    rs.ReservationID
                });

            modelBuilder.Entity<ReservedSeat>()
                .HasOne(rs => rs.Seat)
                .WithMany(rs => rs.ReservedSeats)
                .HasForeignKey(rs => rs.SeatID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Reservation>()
                .HasKey(r => r.ID);
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)
                .WithMany(r => r.Reservations)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
