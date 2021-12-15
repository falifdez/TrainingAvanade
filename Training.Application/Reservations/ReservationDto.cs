using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Application.Books;
using Training.Application.Users;
using Training.Core.Models;

namespace Training.Application.Reservations
{
    public class ReservationDto
    {
        public DateTime CreationDate { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }

        public UserDto UserDto { get; set; }

        public BookDto BookDto { get; set; }


        public Reservation GetEntity()
        {
            return new Reservation
            {
                CreationDate = this.CreationDate,
                ExpectedDeliveryDate = this.ExpectedDeliveryDate,
                Book = this.BookDto.GetEntity(),
                User = this.UserDto.GetEntity()
            };
        }

        public static ReservationDto GetDtoByEntity(Reservation reservation)
        {
            return new ReservationDto
            {
                CreationDate = reservation.CreationDate,
                ExpectedDeliveryDate = reservation.ExpectedDeliveryDate,
                BookDto = BookDto.GetDtoByEntity(reservation.Book),
                UserDto = UserDto.GetDtoByEntity(reservation.User)
            };
        }

    }
}
