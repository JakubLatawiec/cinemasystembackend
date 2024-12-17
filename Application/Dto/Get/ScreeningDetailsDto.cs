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
    public class ScreeningDetailsDto : IMap
    {
        public uint ID { get; set; }
        public string MovieTitle { get; set; } = string.Empty;
        public string RoomName { get; set; } = string.Empty;
        public DateTime ScreeningDate { get; set; }

        public List<SeatDto>? Seats { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Screening, ScreeningDetailsDto>()
                .ForMember(m => m.MovieTitle, c => c.MapFrom(s => s.Movie.Title))
                .ForMember(m => m.RoomName, c => c.MapFrom(s => s.Room.Name))
                .ForMember(m => m.Seats, c => c.MapFrom(s => s.Room.Seats));
        }
    }
}
