using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model.Common;
using Test.DAL.Models;

namespace Test.Service.Common
{
    public interface IVehicleMakeService
    {
        Task<IVehicleMakeDTO> Get(int id);
        Task<IEnumerable<IVehicleMakeDTO>> GetAll();
        Task<IVehicleMakeDTO> Insert(IVehicleMakeDTO entity);
        Task<IVehicleMakeDTO> Update(IVehicleMakeDTO entity);
        Task<int> Delete(int id);

    }
}
