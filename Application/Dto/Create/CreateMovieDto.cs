using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Create
{
    public class CreateMovieDto : IMap
    {
        public uint ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Director { get; set; }
        public DateTime LicenseSince { get; set; }
        public DateTime LicenseUntil { get; set; }
        public uint Length { get; set; }
        public List<CreateScreeningDto>? Screenings { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateMovieDto, Movie>();
        }
    }
}
