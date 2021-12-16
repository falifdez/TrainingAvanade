using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Reservation : IRemovable
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }    

        public User User { get; set; }  

        public Book Book { get; set; }

        public bool IsDeleted { get; set ; }
    }
}
