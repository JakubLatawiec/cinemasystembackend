using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTypeController : ControllerBase
    {
        private readonly ITicketTypeService _screeningService;

        public TicketTypeController(ITicketTypeService screeningService)
        {
            _screeningService = screeningService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _screeningService.GetAllTicketTypes();
            return Ok(data);
        }
    }
}
