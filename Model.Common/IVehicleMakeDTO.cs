using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model.Common
{
    public interface IVehicleMakeDTO
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
        
        //ICollection<IVehicleModelDTO> VehicleModels { get; set; }
    }
}
