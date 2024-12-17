using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningController : ControllerBase
    {
        private readonly IScreeningService _screeningService;
        public ScreeningController(IScreeningService screeningService)
        {
            _screeningService = screeningService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _screeningService.GetAllScreenings();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(uint id) 
        {
            var data = _screeningService.GetScreeningDetails(id);
            if (data == null) { return NotFound(); }
            return Ok(data);
        }
    }
}
