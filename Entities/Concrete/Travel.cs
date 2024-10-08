﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Travel : BaseEntity
    {
        public string TravelName { get; set; }

        public string Description { get; set;}

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
