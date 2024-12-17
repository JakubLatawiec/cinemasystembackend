using Application.Dto.Create;
using Application.Dto.Get;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        UserDto? GetUser(string email);
        User CreateUser(CreateUserDto dto);
    }
}
