﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Core.Models
{
    public class User
    {
        public Guid Guid { get; set; 
        }
        public string Dni { get; set; }

        public string Name { get; set; }
    }
}
