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
    public class ReservationHistoryService : IReservationHistoryService
    {
        private readonly IReservationHistoryRepository _repository;
        private readonly IMapper _mapper;

        public ReservationHistoryService(IReservationHistoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ReservationHistory CreateReservation(CreateReservationHistoryDto dto)
        {
            var reservationHistory = _mapper.Map<ReservationHistory>(dto);
            if (dto.ReservedSeatsHistory != null)
            {
                dto.ReservedSeatsHistory.ForEach(seat => _mapper.Map<ReservedSeatHistory>(seat));
            }
            return _repository.Add(reservationHistory);
        }

        public bool DeleteReservation(uint id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<ReservationHistoryDto>? GetUserReservationHistory(uint userID)
        {
            var data = _repository.GetByUserID(userID);
            return _mapper.Map<IEnumerable<ReservationHistoryDto>>(data);
        }
    }
}
