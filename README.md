# Lambda expressios
   ####The => token is called the lambda operator. It is used in lambda expressions to separate the input variables on the left side from the lambda body on the right side. Lambda expressions are inline expressions similar to anonymous methods but more flexible; they are used extensively in LINQ queries that are expressed in method syntax.

```c#
string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune", "Pluto" };

            int shortestPlanetLength = planets.Min(w => w.Length);
            Console.WriteLine(shortestPlanetLength);
            
         
