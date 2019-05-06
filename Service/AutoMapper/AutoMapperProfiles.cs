﻿using AutoMapper;
using System.Threading.Tasks;
using Test.DAL.Models;
using Test.Model;

namespace Test.Service.Mapping
{
    class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<VehicleMake, VehicleMakeDTO>();
            CreateMap<VehicleModel, VehicleModelDTO>();
            CreateMap<VehicleModelBindingModel, VehicleModelDTO>();
            CreateMap<VehicleMakeBindingModel, VehicleMakeDTO>();

            CreateMap<Task<VehicleMake>, VehicleMakeDTO>();
        }
    }
}
