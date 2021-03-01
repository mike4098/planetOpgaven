using System;
using System.Collections.Generic;
using System.Text;

namespace planeter2
{
    public class planeter
    {
        private string name;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rPeriod;
        private double lDay;
        private double dSun;
        private double orbP;
        private double orbV;
        private double mTemp;
        private double moons;
        private bool rSystem;

        #region properties
        public string Name
        {
            get { return name; }
        }

        public double Mass
        {
            get { return mass; }
        }

        public double Diameter
        {
            get { return diameter; }
        }
        public double Density
        {
            get { return density; }
        }
        public double Gravity
        {
          get { return gravity; }          
        }
        public double Rperiod
        {
            get { return rPeriod; }
        }
        public double Lday
        {
            get { return lDay; }
        }
        public double Dsun
        {
            get { return dSun; }
        }
        public double OrbP
        {
            get { return orbP; }
        }
        public double Orbv
        {
            get { return orbV; }
        }
        public double Mtemp
        {
            get { return mTemp; }
        }
        public double Moons
        {
            get { return moons; }
        }
        public bool Rsystem
        {
            get { return rSystem; }
        }
        #endregion
        #region Constructor
        public planeter(string _Name, double _Mass, double _Diameter, double _Density, double _Gravity, double _Rperiod, double _LDay, double _DSun, double _OrbP, double _OrbV, double _MTemp, double _Moons, bool _RSystem) 
        {
            name = _Name;
            mass = _Mass;
            diameter = _Diameter;
            density = _Density;
            gravity = _Gravity;
            rPeriod = _Rperiod;
            lDay = _LDay;
            dSun = _DSun;
            orbP = _OrbP;
            orbV = _OrbV;
            mTemp = _MTemp;
            moons = _Moons;
            rSystem = _RSystem;

        }
        #endregion
    }
}
