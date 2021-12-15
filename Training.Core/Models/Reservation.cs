using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Core.Models
{
    public class Reservation 
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }    

        public User User { get; set; }  

        public Book Book { get; set; }



    }
}
