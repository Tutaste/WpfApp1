﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Villa : Konut
    {
        public int BahceAlani { get; set; }

        public bool Garaj { get; set; } 

        public bool VillaTipi { get; set; }
    }
}