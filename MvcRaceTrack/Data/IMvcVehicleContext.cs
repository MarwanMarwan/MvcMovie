using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public interface IMvcVehicleContext
    {

        public DbSet<Vehicle> Vehicle { get; set; }

        void Add(Vehicle vehicle);
        Task SaveChangesAsync();
        void Update(Vehicle vehicle);
    }
}