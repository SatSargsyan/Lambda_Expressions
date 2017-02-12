using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune","Pluto" };

            Console.WriteLine("Example that uses a lambda expression:");
                var shortDigits = planets.Where((digit, index) => digit.Length >= index);
                foreach (var p in shortDigits)
                {
                    Console.WriteLine(p);
                }
            Console.Read();
            }
    }
}
