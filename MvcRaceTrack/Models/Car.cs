using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Car : Vehicle
    {
        public int TireWear { get; set; }

        public override bool Inspect()
        {
            return base.Inspect() && (TireWear >= 85);
        }
    }
}
