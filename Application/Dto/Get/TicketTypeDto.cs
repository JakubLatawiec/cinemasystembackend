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
    public class TicketTypeDto : IMap
    {
        public uint ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TicketType, TicketTypeDto>();
        }
    }
}
