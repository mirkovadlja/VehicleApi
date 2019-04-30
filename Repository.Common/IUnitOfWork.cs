using System.Threading.Tasks;
using Test.DAL.Models;

namespace Test.Repository.Common
{
    public interface IUnitOfWork
    {
        IGenericRepository<VehicleMake> VehicleMakeRepository { get; }
        IGenericRepository<VehicleModel> VehicleModelRepository { get; }

        Task<int> Commit();
        void Dispose();
    }
}