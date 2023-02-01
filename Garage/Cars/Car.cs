using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars;

public class Car : Vehicle
{

    public void Drive()
    {
        Console.WriteLine("Driving");
    }
    public void Brake()
    {
        Console.WriteLine("Braking");
    }
}
