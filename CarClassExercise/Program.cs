using System;

namespace CarClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Chrysler";
            myCar.Model = "Town and Country";
            myCar.Year = 1999;

            Console.WriteLine($"My Car is a {myCar.Year} {myCar.Make} {myCar.Model}.");
        }
    }
}
