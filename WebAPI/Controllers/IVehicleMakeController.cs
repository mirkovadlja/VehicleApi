using System.Threading.Tasks;
using System.Web.Http;
using Test.Model;

namespace Test.WebAPI.Controllers
{
    public interface IVehicleMakeController
    {
        Task<IHttpActionResult> Delete(int id);
        Task<IHttpActionResult> Get();
        Task<IHttpActionResult> Get(int id);
        Task<IHttpActionResult> Insert([FromBody] VehicleMakeBindingModel vehicleMakeInsert);
        Task<IHttpActionResult> Update([FromBody] VehicleMakeBindingModel vehicleMakeUpdate);
    }
}