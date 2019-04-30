using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Model.Common;

namespace Test.Model
{
    public class VehicleModelBindingModel : IVehicleModelBindingModel
    {
        public int Id { get; set; }
        public int VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public IVehicleMakeBindingModel VehicleMake { get; set; }
    }
}