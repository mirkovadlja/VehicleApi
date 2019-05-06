using AutoMapper;
using System.Threading.Tasks;
using Test.DAL.Models;
using Test.Model;

namespace Test.Service.Mapping
{
    class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<VehicleMake, VehicleMakeDTO>().ReverseMap().ForMember(x => x.VehicleModels, opt => opt.Ignore()); ;
            CreateMap<VehicleModel, VehicleModelDTO>().ReverseMap();
            CreateMap<VehicleModelBindingModel, VehicleModelDTO>().ReverseMap();
            CreateMap<VehicleMakeBindingModel, VehicleMakeDTO>().ReverseMap();
        }
    }
}
