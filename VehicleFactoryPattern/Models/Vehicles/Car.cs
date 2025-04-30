namespace VehicleFactoryPattern.Models.Vehicles
{
    public class Car : IVehicle
    {
        public string Name { get; set; } = "Car";
        public string Model { get; set; }
        public int Year { get; set; }

        public string GetVehicleInfo()
        {
            return $"This is a {Name}, Model: {Model}, Year: {Year}";
        }
    }
}