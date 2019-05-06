using Test.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL
{
    public class VehicleContext : DbContext, IVehicleContext
    {
        public VehicleContext() : base("VehicleContext") { }

        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<VehicleModel>()
                .HasRequired( model => model.VehicleMake)
                .WithMany( make => make.VehicleModels)
                .HasForeignKey<int>( model => model.VehicleMakeId);
        }
    }

}
