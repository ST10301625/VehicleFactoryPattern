namespace VehicleFactoryPattern.Models.Vehicles
{
    public class Truck : IVehicle
    {
        public string Name { get; set; } = "Truck";
        public string Model { get; set; }
        public int Year { get; set; }

        public string GetVehicleInfo()
        {
            return $"This is a {Name}, Model: {Model}, Year: {Year}";
        }
    }
}