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
    public class CreateScreeningDto : IMap
    {
        public uint RoomID { get; set; }
        public DateTime ScreeningDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateScreeningDto, Screening>();
        }
    }
}
