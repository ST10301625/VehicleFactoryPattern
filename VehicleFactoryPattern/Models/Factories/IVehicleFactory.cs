using VehicleFactoryPattern.Models.Engines;
using VehicleFactoryPattern.Models.Vehicles;

namespace VehicleFactoryPattern.Models.Factories
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string model, int year);
        IEngine CreateEngine();
    }
}