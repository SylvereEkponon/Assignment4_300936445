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
        }
    }
}
