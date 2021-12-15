﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Application.Reservations
{
    public interface IReservationService
    {
        ReservationDto Get(string dni);
    }
}
