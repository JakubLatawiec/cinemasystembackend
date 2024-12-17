using Application.Dto.Create;
using Application.Dto.Get;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _repository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Reservation CreateReservation(CreateReservationDto dto)
        {
            var reservation = _mapper.Map<Reservation>(dto);
            _mapper.Map<List<ReservedSeat>>(dto.ReservedSeats);
            return _repository.Add(reservation);
        }

        public bool DeleteReservation(uint id)
        {
            return _repository.Delete(id);
        }
    }
}
