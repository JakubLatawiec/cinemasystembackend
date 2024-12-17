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
    public class SeatDto : IMap
    {
        public uint ID { get; set; }
        public uint Row { get; set; }
        public uint Number { get; set; }
        public bool IsTaken { get; set; } = false;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Seat, SeatDto>();
        }
    }
}
