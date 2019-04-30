using System;

namespace Test.WebAPI.Models
{
    public interface IVehicleModelBindingModel
    {
        string Abrv { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        IVehicleMakeBindingModel VehicleMake { get; set; }
        Guid VehicleMakeId { get; set; }
    }
}