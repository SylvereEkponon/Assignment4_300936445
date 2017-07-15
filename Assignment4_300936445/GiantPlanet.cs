using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Sylvere Ekponon
 * Date: July 15, 2017
 * Description: The class GiantPlanet is a subclass of the Planet Abstract class.
 * It also implements both the IHasMoons and IHasRings interfaces.
 * version: 0.1 - Created the GiantPlanet class
 */
namespace Assignment4_300936445
{
    /// <summary>
    /// This is the GiantPlanet class
    /// </summary>
    public class GiantPlanet : Planet,IHasMoons,IHasRings
    {

        //PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _type;

        //CONSTRUCTORS------------------------------------
        /// <summary>
        /// This is the main constructor for the GiantPlanet class
        /// It takes four parameters - name(string) diameter(double) mass(double) type(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass,string type):
            base(name,diameter,mass)
        {
            this._type = type;

        }


        //PUBLIC METHODS
        /// <summary>
        /// the HasMoons method returns true if the MoonCount property is greater than zero
        /// </summary>
        /// <returns>bool</returns>
        public bool HasMoons()
        {
            bool result = false;
            if (MoonCount>0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// the HasRingss method returns true if the RingCount property is greater than zero
        /// </summary>
        /// <returns>bool</returns>
        public bool HasRings()
        {
            bool result = false;
            if (RingCount > 0)
            {
                result = true;
            }
            return result;

        }



    }
}
