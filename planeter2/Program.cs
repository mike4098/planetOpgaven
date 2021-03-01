using System;
using System.Collections.Generic;

namespace planeter2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //here we create a list of the planets 
            List<planeter> planets = new List<planeter>();
            planets.Add(new planeter("Mercury", 0.330,  4879,   5427,   3.7,    1407.6, 4222.6,  57.9,   88.0,   47.4,   167,     0,  false));
            planets.Add(new planeter("Venus",   4.87,   12.104, 5243,   8.9,   -5832.5, 2802,    108.2,  224.7,   35.0,   464,    0,  false));
            planets.Add(new planeter("Earth",   5.97,   12.756, 5514,   9.8,    23.9,   24.0,    149.6,  365.2,   29.8,   15,     1,  false));
            planets.Add(new planeter("Mars",    0.642,  6792,   3933,   3.7,    24.6,   24.7,    227.9,  687.0,   24.1,   -65,    2,  false));
            planets.Add(new planeter("Jupiter", 1898,  142.984, 1326,   23.1,   9.9,    9.9,     778.6,  4331,    13.1,  -110,    67, true));
            planets.Add(new planeter("Saturn",   568,  120.536, 687,    9.0,    10.7,   10.7,    1433.5, 10.747,  9.7,    -140,   62,  true));
            planets.Add(new planeter("Uranus",  86.8,   51.118, 1271,   8.7,   -17.2,  -17.2,    2872.5, 30.589,  6.8,   -195,    27,  true));
            planets.Add(new planeter("neptune", 102,   49.528,  1638,   11.0,   16.1,   16.1,    4495.1, 59.8,   5.4,    -200,     14, true ));
            planets.Add(new planeter("Pluto",   0.0146, 2370,   2095,   0.7,    -153.3, 153.3,   5906.4, 90.56,  4.7,    -225,      5,  false ));
            
            foreach(planeter planet in planets)
            {
                Console.WriteLine("------{");
                Console.Write(planet.Name);
                Console.WriteLine("}------");
                Console.WriteLine("Mass (1024kg) = ",planet.Mass);
                Console.WriteLine("Diameter(km) = ", planet.Diameter);
                Console.WriteLine("Density (km/m3) =", planet.Density);
                Console.WriteLine("Gravity = ", planet.Gravity);
                Console.WriteLine("Rotation Period in days =", planet.Rperiod);
                Console.WriteLine("Length of day (hours) =", planet.Lday);
                Console.WriteLine("Orbital Period(days) =", planet.OrbP);
                Console.WriteLine("Orbital Velocity (km/s)=", planet.Orbv);
                Console.WriteLine("Mean Temperature(C)=", planet.Mtemp);
                Console.WriteLine("Moons =", planet.Moons);
                Console.WriteLine("Ring system? =", planet.Rsystem);
            }
            Console.ReadKey();
        }    
    }
}
