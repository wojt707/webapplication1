﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MistrzowieWynajmu.Models2
{
    public class Property
    {
        public int ID { get; set; }
        public PropertyType Type { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int Area { get; set; }
        public bool Washer { get; set; }
        public bool Fridge { get; set; }
        public bool Iron { get; set; }

        public virtual int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
    public enum PropertyType
    {
        House = 0,
        Flat = 1
    }
}
