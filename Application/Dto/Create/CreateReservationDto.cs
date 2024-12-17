using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Create
{
    public class CreateReservationDto : IMap
    {
        public uint UserID { get; set; }
        public bool Paid { get; set; }
        public bool Active { get; set; }
        public List<CreateReservedSeatDto>? ReservedSeats { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateReservationDto, Reservation>();
        }
    }
}
