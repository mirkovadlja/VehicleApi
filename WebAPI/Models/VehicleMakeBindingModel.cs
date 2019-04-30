using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Model.Common;

namespace Test.WebAPI.Models
{
    public class VehicleMakeBindingModel : IVehicleMakeBindingModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

    }
}