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
    public class VehicleMakeService : IVehicleMakeService
    {
        private IUnitOfWork UoW;

        private IMapper Mapper;

        public VehicleMakeService(IUnitOfWork unitOfWork)
        {
            AutoMapperConfiguration.RegisterMappings();
            Mapper = AutoMapperConfiguration.Instance;
            UoW = unitOfWork;
        }

        public async Task<IVehicleMakeDTO> Get(int id)
        {
            VehicleMake vehicleMake = await UoW.VehicleMakeRepository.Get(id);
            return Mapper.Map<VehicleMakeDTO>(vehicleMake);
        }
        public async Task<IEnumerable<IVehicleMakeDTO>> GetAll()
        {

            IEnumerable<VehicleMake> vehicleMakes = await UoW.VehicleMakeRepository.GetAll();
            var a = Mapper.Map<IEnumerable<VehicleMakeDTO>>(vehicleMakes);
            return a;
        }

        public async Task<IVehicleMakeDTO> Insert(IVehicleMakeDTO entity)
        {
            VehicleMake vehicleMakeDB = Mapper.Map<VehicleMake>(entity);
            VehicleMake vehicleMake = await UoW.VehicleMakeRepository.Insert(vehicleMakeDB);
            return Mapper.Map<VehicleMakeDTO>(vehicleMake);

        }

        public async Task<IVehicleMakeDTO> Update(IVehicleMakeDTO entity)
        {
            VehicleMake vehicleMakeDB = Mapper.Map<VehicleMake>(entity);
            VehicleMake vehicleMake = await UoW.VehicleMakeRepository.Update(vehicleMakeDB, vehicleMakeDB.Id);
            return Mapper.Map<VehicleMakeDTO>(vehicleMake);
        }
        public async Task<int> Delete(int id)
        {
            
            int deleted = await UoW.VehicleMakeRepository.Delete(id);
            return deleted;
        }

    }
}
