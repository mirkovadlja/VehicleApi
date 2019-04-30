using System;

namespace Test.Model.Common
{
    public interface IVehicleMakeBindingModel
    {
        string Abrv { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}