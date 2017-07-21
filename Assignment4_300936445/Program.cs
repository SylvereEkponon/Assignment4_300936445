using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Name: Sylvere Ekponon
 * Date: July 12, 2017
 * Description: Assignment 4
 * version: 0.1 - Created the Driver class
 * version: 0.2 - Implemented the GiantPlanet Class
 */
namespace Assignment4_300936445
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 142984, 317.8, "ice");
            Console.WriteLine(giantPlanet.ToString());
            giantPlanet.MoonCount = 69;
            giantPlanet.RingCount = 4;

            if (giantPlanet.HasMoons())
            {
                Console.WriteLine("{0} has {1} Moon(s)", giantPlanet.Name, giantPlanet.MoonCount);
            }
            else
            {
                Console.WriteLine("{0} has no Moon", giantPlanet.Name);
            }

            if (giantPlanet.HasRings())
            {
                Console.WriteLine("{0} has {1} Ring(s)", giantPlanet.Name, giantPlanet.RingCount);
            }
            else
            {
                Console.WriteLine("{0} has no Ring", giantPlanet.Name);
            }
        }
    }
}
