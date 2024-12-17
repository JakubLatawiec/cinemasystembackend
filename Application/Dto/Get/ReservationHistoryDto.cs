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
    public class ReservationHistoryDto : IMap
    {
        public uint ID { get; set; }
        public uint UserID { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public string RoomName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool Paid { get; set; }
        public List<ReservedSeatHistory>? ReservedSeatsHistory { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ReservationHistory, ReservationHistoryDto>();
        }
    }
}
