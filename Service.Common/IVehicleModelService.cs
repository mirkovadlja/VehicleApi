using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Model.Common;

namespace Test.Service.Common
{
    public interface IVehicleModelService
    {
        Task<IVehicleModelDTO> Get(int id);
        Task<IEnumerable<IVehicleModelDTO>> GetAll(int? id);
        Task<IVehicleModelDTO> Insert(IVehicleModelDTO entity);
        Task<IVehicleModelDTO> Update(IVehicleModelDTO entity);
        Task<int> Delete(int id);
       
    }
}
