﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAEMS.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public decimal Registration { get; set; }
        public string Location { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Counrty { get; set; }
    }
}
