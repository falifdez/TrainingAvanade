using Microsoft.AspNetCore.Mvc;
using System;
using Training.Application.Reservations;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{dni}")]
        public IActionResult Get(string dni)
        {
            var reservations = _reservationService.Get(dni);

            return Ok(reservations);
        }

        [HttpPost]
        public IActionResult Post(ReservationDto dto)
        {
            _reservationService.Create(dto);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(ReservationDto dto)
        {
            _reservationService.Update(dto);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid Id)
        {
            _reservationService.Delete(Id);

            return Ok();
        }

    }
}
