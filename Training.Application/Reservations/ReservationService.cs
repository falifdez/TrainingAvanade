using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Reservations
{
    public class ReservationService : IReservationService
    {

        private readonly IReservationRepository _reservationRepository;

        public ReservationDto Get(string dni)
        {
            return ReservationDto.GetDtoByEntity(_reservationRepository.Get(dni));
        }



    }
}
