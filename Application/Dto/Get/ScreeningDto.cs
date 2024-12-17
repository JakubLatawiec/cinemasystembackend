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
    public class ScreeningDto : IMap
    {
        public uint ID { get; set; }
        public uint MovieID { get; set; }
        public uint RoomID { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public DateTime ScreeningDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Screening, ScreeningDto>()
                .ForMember(m => m.RoomName, c => c.MapFrom(s => s.Room.Name));
        }
    }
}
