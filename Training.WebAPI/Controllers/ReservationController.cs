using Microsoft.AspNetCore.Mvc;
using Training.Application.Reservations;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        [HttpGet("{dni}")]
        public IActionResult Get(string dni)
        {
            var reservation = _reservationService.Get(dni);

            return Ok(reservation);
        }

    }
}
