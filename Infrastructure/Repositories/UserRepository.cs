using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CinemaDBContext _dbContext;

        public UserRepository(CinemaDBContext context)
        {
            _dbContext = context;
        }

        public User Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User? GetByEmail(string email)
        {
            var data = _dbContext.Users
               .ToList()
               .SingleOrDefault(user => user.Email == email);
            return data;
        }
    }
}
