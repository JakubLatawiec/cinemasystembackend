using Application.Dto.Create;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateReservationDto dto)
        {
            var data = _reservationService.CreateReservation(dto);
            return Created($"api/[controller]/{data.ID}", data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(uint id) 
        {
            var isDeleted = _reservationService.DeleteReservation(id);

            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
