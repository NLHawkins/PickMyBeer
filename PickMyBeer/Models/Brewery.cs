﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PickMyBeer.Models
{
    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegionId { get; set; }
        public string Website { get; set; }

    }
}