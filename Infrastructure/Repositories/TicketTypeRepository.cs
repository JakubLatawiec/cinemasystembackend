using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TicketTypeRepository : ITicketTypeRepository
    {
        private readonly CinemaDBContext _dbContext;

        public TicketTypeRepository(CinemaDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public IEnumerable<TicketType> GetAll()
        {
            return _dbContext.TicketTypes;
        }
    }
}
