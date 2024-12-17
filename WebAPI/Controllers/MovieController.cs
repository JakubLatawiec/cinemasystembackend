using Application.Dto.Create;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var data = _movieService.GetAllMovies();
            if (data == null) { return NotFound(); }
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var data = _movieService.GetMovieByID(id);
            if (data == null) { return NotFound(); }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateMovieDto dto)
        {
            var data = _movieService.CreateMovie(dto);
            return Created($"api/movie/{data.ID}", data);
        }
    }
}
