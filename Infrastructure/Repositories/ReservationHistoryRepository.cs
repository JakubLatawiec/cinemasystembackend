using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ReservationHistoryRepository : IReservationHistoryRepository

    {
        private readonly CinemaDBContext _dbContext;

        public ReservationHistoryRepository(CinemaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ReservationHistory Add(ReservationHistory reservationHistory)
        {
            _dbContext.Add(reservationHistory);
            _dbContext.SaveChanges();
            return reservationHistory;
        }

        public bool Delete(uint id)
        {
            var history = _dbContext.ReservationsHistory.Where(rh => rh.ID == id).FirstOrDefault();

            if (history == null) return false;

            _dbContext.Remove(history);
            _dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<ReservationHistory>? GetByUserID(uint userID)
        {
            return _dbContext.ReservationsHistory
                .Include(r => r.ReservedSeatsHistory)
                .Where(r => r.UserID == userID)
                .ToList();
        }
    }
}
