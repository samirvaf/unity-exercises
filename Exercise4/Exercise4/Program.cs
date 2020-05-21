using System;

namespace Exercise4
{
    /// <summary>
    /// Calculating with Integers
    /// </summary>
    class Program
    {
        /// <summary>
        /// Promt and calculate distance between two points
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            int distance = secondAltitude - firstAltitude;
            Console.WriteLine($"The distance between these two points is {distance}!");
        }
    }
}
