using Application.Dto.Create;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IReservationHistoryService _service;

        public HistoryController(IReservationHistoryService service)
        {
            _service = service;
        }

        [HttpGet("{userID}")]
        public IActionResult Get(uint userID)
        {
            var data = _service.GetUserReservationHistory(userID);
            if (data == null) { return NotFound(); }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateReservationHistoryDto dto)
        {
            var data = _service.CreateReservation(dto);
            return Created($"api/[controller]/{data.ID}", data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(uint id)
        {
            var isDeleted = _service.DeleteReservation(id);

            if (isDeleted)
                return NoContent();

            return NotFound();
        }
    }
}
