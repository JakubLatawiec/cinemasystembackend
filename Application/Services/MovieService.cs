using Application.Dto.Create;
using Application.Dto.Get;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<MovieDto> GetAllMovies()
        {
            var data = _repository.GetAll();
            return _mapper.Map<IEnumerable<MovieDto>>(data);
        }

        public MovieDto GetMovieByID(int id)
        {
            var data = _repository.GetById(id);
            return _mapper.Map<MovieDto>(data);
        }

        public Movie CreateMovie(CreateMovieDto dto)
        {
            var movie = _mapper.Map<Movie>(dto);
            if (dto.Screenings != null) 
            {
                dto.Screenings.ForEach(screening => _mapper.Map<Screening>(screening));
            }
            return _repository.Add(movie);
        }
    }
}
