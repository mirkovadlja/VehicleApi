using System.Collections.Generic;
using Test.Model.Common;

namespace Test.Model
{
    public class VehicleMakeDTO : IVehicleMakeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
       // public ICollection<IVehicleModelDTO> VehicleModels { get; set; }
    }
}
