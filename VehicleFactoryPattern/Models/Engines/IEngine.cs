namespace VehicleFactoryPattern.Models.Engines
{
    public interface IEngine
    {
        string Type { get; }
        string GetEngineInfo();
    }
}