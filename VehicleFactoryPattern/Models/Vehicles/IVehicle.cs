namespace VehicleFactoryPattern.Models.Vehicles
{
    public interface IVehicle
    {
        string Name { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        string GetVehicleInfo();
    }
}