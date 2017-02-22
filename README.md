# Lambda expressios
####A lambda expression is an anonymous function that you can use to create delegates or expression tree types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.
To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator =>, and you put the expression or statement block on the other side. For example, the lambda expression x => x * x specifies a parameter that’s named x and returns the value of x squared. You can assign this expression to a delegate type, as the following example shows:

```C#


### The first program
```C#
string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune","Pluto" };

            Console.WriteLine("Example that uses a lambda expression:");
                var shortDigits = planets.Where((digit, index) => digit.Length >= index);
                foreach (var p in shortDigits)
                {
                    Console.WriteLine(p);
                }
              ```
### The second program
#### The => token is called the lambda operator. It is used in lambda expressions to separate the input variables on the left side from the lambda body on the right side. Lambda expressions are inline expressions similar to anonymous methods but more flexible; they are used extensively in LINQ queries that are expressed in method syntax.

```c#
string[] planets = { "The Sun", "Mercury", "Venus", "Earth",
            "Mars", "Jupiter", "Saturn","Uranus", "Neptune", "Pluto" };

            int shortestPlanetLength = planets.Min(w => w.Length);
            Console.WriteLine(shortestPlanetLength);
            ```
            
           

            
            
         
