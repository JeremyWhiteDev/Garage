using Garage;
using Garage.Aircraft;
using Garage.Cars;
using Garage.WaterCraft;

static void Main()
{
    // Build a collection of all vehicles that fly
    List<Aircraft> allAircraft = new List<Aircraft> { new Boeing737(), new MilleniumFalcon() };

    // With a single `foreach`, have each vehicle Fly()
    foreach (Aircraft aircraft in allAircraft)
    {
        aircraft.Fly();
    }


    // Build a collection of all vehicles that operate on roads
    List<Car> allCars = new List<Car> { new NissanLeaf(), new Porsche() };
    // With a single `foreach`, have each road vehicle Drive()

    foreach (Car car in allCars)
    {
        car.Drive();
    }


    // Build a collection of all vehicles that operate on water
    // With a single `foreach`, have each water vehicle Drive()
    List<Watercraft> allWaterCraft = new List<Watercraft> { new AboatTime(), new BoatyMcBoatFace() };

    foreach (Watercraft watercraft in allWaterCraft)
    {
        watercraft.Sail();
    }

}