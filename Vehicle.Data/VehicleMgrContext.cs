using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Data.Models;

namespace Vehicle.Data
{
    public class VehicleMgrContext : DbContext
    {
        public VehicleMgrContext(DbContextOptions<VehicleMgrContext> options) :base(options)
        {

        }

        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<VehicleDetails> VehicleDetails { get; set; }
    }
}
