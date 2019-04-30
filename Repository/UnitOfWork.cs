using System;
using System.Threading.Tasks;
using Test.DAL;
using Test.DAL.Models;
using Test.Repository.Common;

namespace Test.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private VehicleContext context = new VehicleContext();
        private GenericRepository<VehicleMake> vehicleMakeRepository;
        private GenericRepository<VehicleModel> vehicleModelRepository;
        private bool disposed = false;
        public IGenericRepository<VehicleMake> VehicleMakeRepository
        {
            get
            {

                if (this.vehicleMakeRepository == null)
                {
                    this.vehicleMakeRepository = new GenericRepository<VehicleMake>(context);
                }
                return vehicleMakeRepository;
            }
        }
        public IGenericRepository<VehicleModel> VehicleModelRepository
        {
            get
            {

                if (this.vehicleModelRepository == null)
                {
                    this.vehicleModelRepository = new GenericRepository<VehicleModel>(context);
                }
                return vehicleModelRepository;
            }
        }


        public async Task<int> Commit()
        {
            return await this.context.SaveChangesAsync();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
