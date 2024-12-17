using Application.Dto.Get;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ScreeningService : IScreeningService
    {
        private readonly IScreeningRepository _repository;
        private readonly IMapper _mapper;
        public ScreeningService(IScreeningRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<ScreeningDetailsDto> GetAllScreenings()
        {
            var data = _repository.GetAll();
            return _mapper.Map<IEnumerable<ScreeningDetailsDto>>(data);
        }

        public ScreeningDetailsDto? GetScreeningDetails(uint id)
        {
            var reservedSeats = _repository.GetReservedSeats(id);
            var data = _repository.GetById(id);

            if (data == null)
            {
                return null;
            }

            var screeningDetails = _mapper.Map<ScreeningDetailsDto>(data);
            if (screeningDetails.Seats != null)
            {
                screeningDetails.Seats.ForEach(seat =>
                {
                    if (reservedSeats.Contains(seat.ID))
                    {
                        seat.IsTaken = true;
                    }
                    else
                    {
                        seat.IsTaken = false;
                    }
                });
            }
            return screeningDetails;
        }
    }
}
