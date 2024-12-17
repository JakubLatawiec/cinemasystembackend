using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Get
{
    public class ReservedSeatHistoryDto : IMap
    {
        public uint ID { get; set; }
        public uint ReservationHistoryID { get; set; }
        public uint SeatID { get; set; }
        public uint SeatNumber { get; set; }
        public uint SeatRow { get; set; }
        public string TicketType { get; set; } = string.Empty;
        public float Price { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ReservedSeatHistory,  ReservedSeatHistoryDto>();
        }
    }
}
