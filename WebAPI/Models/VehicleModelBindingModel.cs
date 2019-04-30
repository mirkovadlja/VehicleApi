using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.WebAPI.Models
{
    public class VehicleModelBindingModel : IVehicleModelBindingModel
    {
        public Guid Id { get; set; }
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public IVehicleMakeBindingModel VehicleMake { get; set; }
    }
}