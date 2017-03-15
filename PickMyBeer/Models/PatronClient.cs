﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PickMyBeer.Models
{
    public class PatronClient
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public BeerCollection PrevSearchedBeers { get; set; }
        public BeerCollection FaveBeers { get; set; }
    }
}