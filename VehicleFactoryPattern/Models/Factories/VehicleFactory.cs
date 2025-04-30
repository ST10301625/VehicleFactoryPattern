using VehicleFactoryPattern.Models.Vehicles;

namespace VehicleFactoryPattern.Models.Factories
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType, string model, int year)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car { Model = model, Year = year };
                case "motorcycle":
                    return new Motorcycle { Model = model, Year = year };
                case "truck":
                    return new Truck { Model = model, Year = year };
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}