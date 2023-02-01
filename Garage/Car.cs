using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage;

public class Car
{
    public int FuelCapacity { get; set; }
    public string Color { get; set; }
    public int PassengerCapacity { get; set; }
    public int FuelLevel { get; set; }

    public int MPG { get; set; }



    public void Refuel()
    {
        Console.WriteLine("Refueling");
        int neededFuel = FuelCapacity - FuelLevel;
        FuelLevel = FuelCapacity;
        Console.WriteLine($"You just put {neededFuel} gallons of gas in your vehicle. ");
    }

    public void Drive()
    {
        Console.WriteLine("Driving");
    }
    public void Brake()
    {
        Console.WriteLine("Braking");
    }
}
