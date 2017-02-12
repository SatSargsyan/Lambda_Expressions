using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune", "Pluto" };

            int shortestPlanetLength = planets.Min(w => w.Length);
            Console.WriteLine(shortestPlanetLength);

            Console.Read();
        }
    }
}
