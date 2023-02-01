using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.WaterCraft;

public class Watercraft : Vehicle
{


    public void Sail()
    {
        Console.WriteLine("Sailing");
    }
    public void Dock()
    {
        Console.WriteLine("Docking");
    }
}
