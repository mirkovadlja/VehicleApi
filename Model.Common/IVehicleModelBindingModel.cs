namespace Test.Model.Common
{
    public interface IVehicleModelBindingModel
    {
        string Abrv { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        IVehicleMakeBindingModel VehicleMake { get; set; }
        int VehicleMakeId { get; set; }
    }
}