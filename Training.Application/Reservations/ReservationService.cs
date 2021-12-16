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

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void Create(ReservationDto reservationDto)
        {
            _reservationRepository.Create(reservationDto.GetEntity());
        }

        public void Delete(Guid Id)
        {
            var reser = _reservationRepository.Get(Id);
            reser.IsDeleted = true;
            _reservationRepository.Update(reser);
        }

        public IList<ReservationDto> Get(string dni)
        {
            return _reservationRepository.Get(dni).Select(x => ReservationDto.GetDtoByEntity(x)).ToList();
        }

        public ReservationDto Get(Guid id)
        {
            return ReservationDto.GetDtoByEntity(_reservationRepository.Get(id));

        }

        public void Update(ReservationDto reservationDto)
        {
            var reser = _reservationRepository.Get(reservationDto.Id); 

            reser.ExpectedDeliveryDate = reservationDto.ExpectedDeliveryDate;

            _reservationRepository.Update(reser);

        }
    }
}
