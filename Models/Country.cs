﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ASP.NETCoreWebAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            Locations = new HashSet<Location>();
        }

        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
