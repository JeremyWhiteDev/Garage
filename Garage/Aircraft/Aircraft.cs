using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Aircraft;

public class Aircraft : Vehicle
{





    public void Fly()
    {
        Console.WriteLine("Flying");
    }
    public void Land()
    {
        Console.WriteLine("Landing");
    }
}
