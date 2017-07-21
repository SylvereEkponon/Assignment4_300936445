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
 *              - Overridden the ToString Method
 *  version: 0.2 - Fixed bugs in the Planet class            
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
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        
        public int MoonCount {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;

            }
        }
        public string Name {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        


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
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }


        //PRIVATE METHODS


        //PUBLIC METHODS
        /// <summary>
        /// ToString method outputs the name, the diameter and the mass to the console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name: {0}, Diameter: {1} km, and Mass: {2} Earths", this.Name, this.Diameter, this.Mass);
        }

    }
}
