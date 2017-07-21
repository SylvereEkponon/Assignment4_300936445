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
 * version: 0.3 - Added WaitForAnyKey Method
 * version: 0.4 - Implemented the TerrestrialPlanet Class
 * Git Repo: https://github.com/SylvereEkponon/Assignment4_300936445
 */
namespace Assignment4_300936445
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================================");
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 142984, 317.8, "ice");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("=====================================================================");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 4879, 0.055, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            WaitForAnyKey();
        }

        /// <summary>
        ///This is WaitForAnyKey method
        ///It reads the console for any key press before the console is closed
        /// </summary>
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
