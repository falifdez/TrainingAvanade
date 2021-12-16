using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IReservationRepository
    {
        IList<Reservation> Get(string dni);

        Reservation Get(Guid id);

        void Create(Reservation reservation);

        void Update(Reservation reservation);

    }
}
