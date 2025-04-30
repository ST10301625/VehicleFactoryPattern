namespace VehicleFactoryPattern.Models.Engines
{
    public class HybridEngine : IEngine
    {
        public string Type => "Hybrid";

        public string GetEngineInfo()
        {
            return "This vehicle has a hybrid engine (both electric and gasoline)";
        }
    }
}