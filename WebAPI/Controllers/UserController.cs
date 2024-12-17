using Application.Dto.Create;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public IActionResult Get(string email)
        {
            var data = _userService.GetUser(email);
            if (data == null) { return NotFound(); }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserDto dto)
        {
            var data = _userService.CreateUser(dto);
            return Created($"api/movie/{data.ID}", data);
        }
    }
}
