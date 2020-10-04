using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Truck : Vehicle
    {
        public int Lift { get; set; }

        public override bool Inspect()
        {
            return base.Inspect() && (Lift <= 5);
        }
    }
}
