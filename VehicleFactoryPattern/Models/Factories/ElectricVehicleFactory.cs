using VehicleFactoryPattern.Models.Engines;
using VehicleFactoryPattern.Models.Vehicles;

namespace VehicleFactoryPattern.Models.Factories
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        private readonly string _vehicleType;

        public ElectricVehicleFactory(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public IVehicle CreateVehicle(string model, int year)
        {
            var vehicle = VehicleFactory.CreateVehicle(_vehicleType, model, year);
            return vehicle;
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}