using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DAL.Models;
using Test.Model;
using Test.Model.Common;
using Test.Repository;
using Test.Repository.Common;
using Test.Service.Common;
using Test.Service.Mapping;

namespace Test.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        private IUnitOfWork UoW;
        private IMapper Mapper;

        public VehicleModelService(IUnitOfWork unitOfWork)
        {
            AutoMapperConfiguration.RegisterMappings();
            Mapper = AutoMapperConfiguration.Instance;
            UoW = unitOfWork;
        }


        public async Task<IVehicleModelDTO> Get(int id)
        {
            VehicleModel vehicleModel = await UoW.VehicleModelRepository.Get(id);
            return Mapper.Map<VehicleModelDTO>(vehicleModel);
        }

        public async Task<IEnumerable<IVehicleModelDTO>> GetAll()
        {

            IEnumerable<VehicleModel> vehicleModels = await UoW.VehicleModelRepository.GetAll(includeProperties: "VehicleMake");
            var a = Mapper.Map<IEnumerable<VehicleModelDTO>>(vehicleModels);
            return a;
        }

        public async Task<IVehicleModelDTO> Insert(IVehicleModelDTO entity)
        {
            VehicleModel vehicleModelDB = Mapper.Map<VehicleModel>(entity);
            VehicleModel vehicleModel = await UoW.VehicleModelRepository.Insert(vehicleModelDB);
            return Mapper.Map<VehicleModelDTO>(vehicleModel);
        }

        public async Task<IVehicleModelDTO> Update(IVehicleModelDTO entity)
        {
            VehicleModel vehicleModelDB = Mapper.Map<VehicleModel>(entity);
            VehicleModel vehicleModel = await UoW.VehicleModelRepository.Update(vehicleModelDB, vehicleModelDB.Id);
            return Mapper.Map<VehicleModelDTO>(vehicleModel);
        }
        public async Task<int> Delete(int id)
        {
            int deleted = await UoW.VehicleModelRepository.Delete(id);
            return deleted;
        }

    }
}
