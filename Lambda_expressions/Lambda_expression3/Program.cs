using System;
using System.Linq;


namespace Lambda_expression3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune","Pluto" };

            var query = from w in planets
                        select w.Length;

            // Apply the Min method to execute the query and get the shortest length.  
            int shortestPlanetLength2 = query.Min();
            Console.WriteLine("The shortest length of the planet is {0}", shortestPlanetLength2);

            // Apply the Max method to execute the query and get the largest length.  
            int largestPlanetLength3 = query.Max();
            Console.WriteLine("The largest length of the planet is {0}", largestPlanetLength3);
            
            Console.Read();
        }
    }
}
