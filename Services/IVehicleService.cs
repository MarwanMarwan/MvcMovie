using MvcMovie.Models;
using System.Collections.Generic;

namespace MvcMovie.Services
{
    public interface IVehicleService
    {
        IList<Vehicle> GetVehicles();
    }
}
