using Application.Dto.Create;
using Application.Dto.Get;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReservationService
    {
        Reservation CreateReservation(CreateReservationDto dto);
        bool DeleteReservation(uint id);
    }
}
