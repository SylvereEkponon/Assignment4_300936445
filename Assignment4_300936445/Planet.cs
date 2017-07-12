using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Sylvere Ekponon
 * Date: July 12, 2017
 * Description: This is the Abstract Planet class
 * version: 0.1 - Created the Abstract Planet class 
 *              - Overridden the ToSting Method
 */            

namespace Assignment4_300936445
{
    /// <summary>
    /// This is the Abstract Planet class
    /// </summary>
    public abstract class Planet
    {

        //PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }


        //CONSTRUCTOR---------------------------------------------
        /// <summary>
        /// This is the main constructor for the Planet class
        /// It takes three parameters - name (string) diamneter (double) mass (double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name,double diameter,double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }


        //PRIVATE METHODS


        //PUBLIC METHODS
        /// <summary>
        /// ToString method outputs the name, the diameter and the mass to the console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name: {0}, Diameter: {1}, and Mass: {2}", this.Name, this.Diameter, this.Mass);
        }

    }
}
