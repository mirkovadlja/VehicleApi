using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model.Common
{
    public interface IVehicleModelDTO
    {
        int Id { get; set; }
        int VehicleMakeId { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
        IVehicleMakeDTO VehicleMake { get; set; }
    }
}
