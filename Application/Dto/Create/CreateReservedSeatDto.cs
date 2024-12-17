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
    public class CreateReservedSeatDto : IMap
    {
        public uint SeatID { get; set; }
        public uint ScreeningID { get; set; }
        public uint TicketTypeID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateReservedSeatDto, ReservedSeat>();
        }
    }
}
