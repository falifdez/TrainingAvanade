using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class ReservationRepository : IReservationRepository
    {

        private IList<Reservation> _reservations;


        public ReservationRepository()
        {
            _reservations = new List<Reservation>
            {
                new Reservation{ Id = Guid.NewGuid(), User = new User{Guid = Guid.Parse("4c3b999f-64a5-4dce-a08c-c0d426944240"), Dni="11111111A", Name="Jóse Pérez López" }, CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), Book = new Book{Id = Guid.NewGuid(), Author = "Dios", ISBN = "ISBN1111", Name ="La Biblia" } },
                new Reservation{ Id = Guid.NewGuid(), User = new User{Guid = Guid.Parse("4c3b999f-64a5-4dce-a08c-c0d426944240"), Dni="11111111A", Name="Jóse Pérez López" }, CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), Book = new Book{Id = Guid.NewGuid(), Author = "Don Quijote", ISBN = "ISBN2222", Name ="Cervantes" } },
                new Reservation{ Id = Guid.NewGuid(), User = new User{Guid = Guid.Parse("84d9e693-2340-4a96-886e-4eb410ca6bfe"), Dni="33333333C", Name="Rafael Gámez Vergara" }, CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), Book = new Book{Id = Guid.NewGuid(), Author = "Homero", ISBN = "ISBN33333", Name ="Homero" } }
            };
        }
        public void Create(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public IList<Reservation> Get(string dni)
        {
            return _reservations.Where(x => x.User.Dni == dni && !x.IsDeleted).ToList();
        }

        public Reservation Get(Guid id)
        {
            return _reservations.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Reservation reservation)
        {

            _reservations = _reservations.Where(x => x.Id != reservation.Id).ToList();

            _reservations.Add(reservation);

        }
    }
}
