using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IScreeningRepository
    {
        IEnumerable<Screening> GetAll();
        Screening? GetById(uint id);
        IEnumerable<uint> GetReservedSeats(uint id);
    }
}
