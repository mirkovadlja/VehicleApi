using System;

namespace Test.DAL.Models
{
    public interface IVehicleModel
    {
        string Abrv { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        VehicleMake VehicleMake { get; set; }
        int VehicleMakeId { get; set; }
    }
}