using VehicleFactoryPattern.Models.Engines;
using VehicleFactoryPattern.Models.Vehicles;

namespace VehicleFactoryPattern.Models.Factories
{
    public class HybridVehicleFactory : IVehicleFactory
    {
        private readonly string _vehicleType;

        public HybridVehicleFactory(string vehicleType)
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
            return new HybridEngine();
        }
    }
}