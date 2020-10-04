using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Services
{
    public class VehicleService : IVehicleService
    {
        public IList<Vehicle> GetVehicles()
        {
            return new List<Vehicle> { new Vehicle { Specs = "Ford 2011" }, new Vehicle { Specs = "Lexus 2011" }, new Vehicle { Specs = "Toyota 2011" } };
        }
    }
}
