using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CinemaDBContext _dbContext;

        public ReservationRepository(CinemaDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public Reservation Add(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public bool Delete(uint id)
        {
            var reservation = _dbContext.Reservations.Where(r => r.ID == id).FirstOrDefault();

            if (reservation != null)
            {
                _dbContext.Remove(reservation);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
