Vehicle Factory Pattern - MVC Implementation

Overview
This project demonstrates the implementation of both Factory Method and Abstract Factory design patterns in an ASP.NET Core MVC application. The solution allows users to create different types of vehicles (cars, motorcycles, trucks) with various engine configurations (electric, gasoline, hybrid).

Design & Implementation Choices

Architectural Pattern
- MVC (Model-View-Controller): Chosen for clear separation of concerns and to align with ASP.NET Core's default architecture.

Factory Patterns Implemented
1. Factory Method Pattern:
   - Used for creating different vehicle types (Car, Motorcycle, Truck)
   - Implemented in `VehicleFactory` static class
   - Simple switch-based approach for clear vehicle type selection

2. Abstract Factory Pattern:
   - Used for creating engine-vehicle combinations
   - Implemented through `IVehicleFactory` interface and concrete factories
   - Ensures that vehicles are created with compatible engines

Class Structure
Interfaces:
  - IVehicle: Base contract for all vehicles
  - IEngine: Base contract for all engine types
  - IVehicleFactory: Abstract factory interface

  Concrete Implementations:
  - Vehicles: `Car`, `Motorcycle`, `Truck`
  - Engines: `ElectricEngine`, `GasolineEngine`, `HybridEngine`
  - Factories: `ElectricVehicleFactory`, `GasolineVehicleFactory`, `HybridVehicleFactory`

Bonus Challenges Implemented
1. Added `Truck` vehicle type
2. Added `HybridEngine` and corresponding factory

