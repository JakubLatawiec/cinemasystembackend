using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IReservationHistoryRepository
    {
        IEnumerable<ReservationHistory>? GetByUserID(uint userID);
        ReservationHistory Add(ReservationHistory reservationHistory);
        bool Delete(uint id);
    }
}
