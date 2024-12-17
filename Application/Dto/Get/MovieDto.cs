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
    public class MovieDto : IMap
    {
        public uint ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public uint Length { get; set; }
        public List<ScreeningDto>? Screenings { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Movie, MovieDto>();
        }
    }
}
