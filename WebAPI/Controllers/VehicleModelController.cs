using AutoMapper;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Test.Model;
using Test.Service;
using Test.Service.Common;
using Test.Service.Mapping;

namespace Test.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class VehicleModelController : ApiController, IVehicleModelController
    {
        private IMapper Mapper;
        protected IVehicleModelService Service { get; private set; }

        public VehicleModelController(IVehicleModelService service)
        {
            AutoMapperConfiguration.RegisterMappings();
            Mapper = AutoMapperConfiguration.Instance;
            this.Service = service;
        }

        

        [Route("api/vehiclemodel/get")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var vehicleModels = await Service.GetAll();
            return Ok(vehicleModels);
        }

        [Route("api/vehiclemodel/get/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            var vehicleModel = await Service.Get(id);
            return Ok(vehicleModel);
        }

        [Route("api/vehiclemodel/insert")]
        [HttpPost]
        public async Task<IHttpActionResult> Insert([FromBody]VehicleModelBindingModel vehicleModelInsert)
        {
            var vehicleModel = await Service.Insert(Mapper.Map<VehicleModelDTO>(vehicleModelInsert));
            return Ok(vehicleModel);
        }

        [Route("api/vehiclemodel/update")]
        [HttpPost]
        public async Task<IHttpActionResult> Update([FromBody]VehicleModelBindingModel vehicleModelUpdate)
        {
            var vehicleModel = await Service.Update(Mapper.Map<VehicleModelDTO>(vehicleModelUpdate));
            return Ok(vehicleModel);
        }

        [Route("api/vehiclemodel/delete/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> Delete(int id)
        {
            int response = await Service.Delete(id);
            return Ok(response);
        }
    }
}
