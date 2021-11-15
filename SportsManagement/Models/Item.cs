﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagement.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
