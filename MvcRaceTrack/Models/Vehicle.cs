using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Vehicle
    {
        public string Specs { get; set; }
        public int Id { get; set; }
        public bool TowStrap { get; set; }

        public virtual bool Inspect()
        {
            return TowStrap;
        }
    }
}
