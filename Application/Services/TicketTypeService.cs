using Application.Dto.Get;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TicketTypeService : ITicketTypeService
    {
        private readonly ITicketTypeRepository _repository;
        private readonly IMapper _mapper;

        public TicketTypeService(ITicketTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<TicketTypeDto> GetAllTicketTypes()
        {
            var data = _repository.GetAll();
            return _mapper.Map<IEnumerable<TicketTypeDto>>(data);
        }
    }
}
