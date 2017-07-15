using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Sylvere Ekponon
 * Date: July 15, 2017
 * Description: The class TerrestrialPlanet is a subclass of the Planet Abstract class.
 * It also implements both the IHasMoons and IHabitable interfaces.
 * version: 0.1 - Created the TerrestrialPlanet class
 */

namespace Assignment4_300936445
{
    public class TerrestrialPlanet : Planet,IHabitable,IHasMoons
    {
        //PRIVATE INSTANCE VARIABLE
        private bool _oxygen;

        //CONSTRUCTOR
        /// <summary>
        /// This is the main constructor for the TerrestrialPlanet class
        /// It takes four parameters - name(string) diameter(double) mass(double) oxygen(bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen):
            base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }


        //PUBLIC METHODS

        /// <summary>
        /// the HasMoons method returns true if the MoonCount property is greater than zero
        /// </summary>
        /// <returns>bool</returns>
        public bool HasMoons()
        {
            bool result = false;
            if (MoonCount > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// the Habitable method returns true if the oxygen instance variable is set to true
        /// </summary>
        /// <returns>bool</returns>
        public bool Habitable()
        {
            return _oxygen;
        }

    }
}
