using System;
using System.Collections.Generic;

namespace Training.Application.Reservations
{
    public interface IReservationService
    {
        IList<ReservationDto> Get(string dni);

        ReservationDto Get(Guid id);

        void Create(ReservationDto reservationDto);

        void Update(ReservationDto reservationDto);

        void Delete(Guid Id);
    }
}
