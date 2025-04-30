namespace VehicleFactoryPattern.Models.Engines
{
    public class ElectricEngine : IEngine
    {
        public string Type => "Electric";

        public string GetEngineInfo()
        {
            return "This vehicle has an electric engine";
        }
    }
}