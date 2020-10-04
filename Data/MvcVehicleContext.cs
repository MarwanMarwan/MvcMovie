using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class MvcVehicleContext : DbContext
    {
        public MvcVehicleContext(DbContextOptions<MvcVehicleContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}