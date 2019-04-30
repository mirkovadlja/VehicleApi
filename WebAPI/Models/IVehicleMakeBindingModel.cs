using System;

namespace Test.WebAPI.Models
{
    public interface IVehicleMakeBindingModel
    {
        string Abrv { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
    }
}