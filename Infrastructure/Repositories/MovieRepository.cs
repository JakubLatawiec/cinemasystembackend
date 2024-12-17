using Application.Dto;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CinemaDBContext _dbContext;

        public MovieRepository(CinemaDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _dbContext.Movies.Include(m => m.Screenings).ThenInclude(s => s.Room).ToList();
        }

        public Movie? GetById(int id)
        {
            var data = _dbContext.Movies
                .Include(m => m.Screenings)
                .ToList()
                .SingleOrDefault(movie => movie.ID == id);
            return data;
        }
        public Movie Add(Movie movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return movie;
        }
    }
}