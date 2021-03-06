﻿using System;
using System.Collections.Generic;

namespace REST_API.Web_API.Database
{
    public partial class VehicleModel
    {
        public VehicleModel()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int? ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
