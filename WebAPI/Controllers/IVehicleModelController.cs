using System.Threading.Tasks;
using System.Web.Http;
using Test.Model;

namespace Test.WebAPI.Controllers
{
    public interface IVehicleModelController
    {
        Task<IHttpActionResult> Delete(int id);
        Task<IHttpActionResult> Get();
        Task<IHttpActionResult> Get(int id);
        Task<IHttpActionResult> Insert([FromBody] VehicleModelBindingModel vehicleModelInsert);
        Task<IHttpActionResult> Update([FromBody] VehicleModelBindingModel vehicleModelUpdate);
    }
}