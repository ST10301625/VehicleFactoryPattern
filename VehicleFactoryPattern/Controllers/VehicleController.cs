using Microsoft.AspNetCore.Mvc;
using VehicleFactoryPattern.Models.Factories;
using VehicleFactoryPattern.Models.Vehicles;

namespace VehicleFactoryPattern.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string vehicleType, string engineType, string model, int year)
        {
            IVehicleFactory factory = engineType.ToLower() switch
            {
                "electric" => new ElectricVehicleFactory(vehicleType),
                "gasoline" => new GasolineVehicleFactory(vehicleType),
                "hybrid" => new HybridVehicleFactory(vehicleType),
                _ => throw new ArgumentException("Invalid engine type"),
            };

            var vehicle = factory.CreateVehicle(model, year);
            var engine = factory.CreateEngine();

            ViewBag.VehicleInfo = vehicle.GetVehicleInfo();
            ViewBag.EngineInfo = engine.GetEngineInfo();

            return View("Index");
        }
    }
}