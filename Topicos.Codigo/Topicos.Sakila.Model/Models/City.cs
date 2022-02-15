﻿using System;
using System.Collections.Generic;

namespace Topicos.Sakila.Model.Models
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int CityId { get; set; }
        public string City1 { get; set; } = null!;
        public short CountryId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
