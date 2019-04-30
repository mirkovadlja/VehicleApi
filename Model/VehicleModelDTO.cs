using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Common;

namespace Test.Model
{
    public class VehicleModelDTO : IVehicleModelDTO
    {
        public int Id { get; set; }
        public int VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public IVehicleMakeDTO VehicleMake { get; set; }
    }
}
