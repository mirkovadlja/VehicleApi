using AutoMapper;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Test.Model;
using Test.Service.Common;
using Test.Service.Mapping;

namespace Test.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class VehicleMakeController : ApiController, IVehicleMakeController
    {
        private IMapper Mapper;

        public VehicleMakeController(IVehicleMakeService service)
        {
            AutoMapperConfiguration.RegisterMappings();
            Mapper = AutoMapperConfiguration.Instance;
            this.Service = service;
        }
        protected IVehicleMakeService Service { get; private set; }

        [Route("api/vehiclemake/get")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var vehicleMakes = await Service.GetAll();
            return Ok(vehicleMakes);
        }

        [Route("api/vehiclemake/get/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            var vehicleMake = await Service.Get(id);
            return Ok(vehicleMake);
        }

        [Route("api/vehiclemake/insert")]
        [HttpPost]
        public async Task<IHttpActionResult> Insert([FromBody]VehicleMakeBindingModel vehicleMakeInsert)
        {
            var vehicleMake = await Service.Insert(Mapper.Map<VehicleMakeDTO>(vehicleMakeInsert));
            return Ok(vehicleMake);
        }

        [Route("api/vehiclemake/update")]
        [HttpPost]
        public async Task<IHttpActionResult> Update([FromBody]VehicleMakeBindingModel vehicleMakeUpdate)
        {
            var vehicleMake = await Service.Update(Mapper.Map<VehicleMakeDTO>(vehicleMakeUpdate));
            return Ok(vehicleMake);
        }

        [Route("api/vehiclemake/delete/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> Delete(int id)
        {
            int response = await Service.Delete(id);
            return Ok(response);
        }
    }
}
