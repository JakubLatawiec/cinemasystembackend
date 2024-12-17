using Application.Dto.Get;
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
    public class CreateReservationSeatHistory : IMap
    {
        public uint SeatID { get; set; }
        public uint SeatNumber { get; set; }
        public uint SeatRow { get; set; }
        public string TicketType { get; set; } = string.Empty;
        public float Price { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateReservationSeatHistory, ReservedSeatHistory>();
        }
    }
}
