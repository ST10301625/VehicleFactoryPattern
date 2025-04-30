namespace VehicleFactoryPattern.Models.Engines
{
    public class GasolineEngine : IEngine
    {
        public string Type => "Gasoline";

        public string GetEngineInfo()
        {
            return "This vehicle has a gasoline engine";
        }
    }
}