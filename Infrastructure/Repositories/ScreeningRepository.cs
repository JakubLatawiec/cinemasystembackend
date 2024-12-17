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
    public class ScreeningRepository : IScreeningRepository
    {
        private readonly CinemaDBContext _dbContext;

        public ScreeningRepository(CinemaDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IEnumerable<Screening> GetAll()
        {
            return _dbContext.Screenings
                .Include(s => s.Movie)
                .Include(s => s.Room)
                .ThenInclude(r => r.Seats)
                .ToList();
        }

        public Screening? GetById(uint id)
        {
            return _dbContext.Screenings
                .Include(s => s.Movie)
                .Include(s => s.Room)
                .ThenInclude(r => r.Seats)
                .ToList()
                .SingleOrDefault(s => s.ID == id);
        }

        public IEnumerable<uint> GetReservedSeats(uint id) 
        {
            return _dbContext.ReservedSeats.Where(rs => rs.ScreeningID == id).Select(rs => rs.SeatID).ToList();
        }
    }
}
