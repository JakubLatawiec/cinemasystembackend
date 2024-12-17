using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Get
{
    public class ReservedSeatsDto : IMap
    {
        public uint SeatID { get; set; }
        public uint SeatRow { get; set; }
        public uint SeatNumber { get; set; }
        public string RoomName { get; set; } = string.Empty;
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ReservedSeat, ReservedSeatsDto>()
                .ForMember(rs => rs.SeatID, c => c.MapFrom(s => s.Seat.ID))
                .ForMember(rs => rs.SeatRow, c => c.MapFrom(s => s.Seat.Row))
                .ForMember(rs => rs.SeatNumber, c => c.MapFrom(s => s.Seat.Number))
                .ForMember(rs => rs.RoomName, c => c.MapFrom(s => s.Seat.Room.Name));
        }
    }
}
