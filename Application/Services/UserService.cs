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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public User CreateUser(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            return _repository.Add(user);
        }

        public UserDto? GetUser(string email)
        {
            var data = _repository.GetByEmail(email);
            return _mapper.Map<UserDto>(data);
        }
    }
}
