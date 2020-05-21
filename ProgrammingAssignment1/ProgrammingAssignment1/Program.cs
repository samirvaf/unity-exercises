using System;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// It's all Greek to Me!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program will calculate the distance and the angle between 2 points.");

            // Gets X and Y for the first point
            Console.Write("Enter first point X value: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter first point Y value: ");
            float point1Y = float.Parse(Console.ReadLine());

            // Gets X and Y for the second point
            Console.Write("Enter second point X value: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter second point Y value: ");
            float point2Y = float.Parse(Console.ReadLine());

            // Calculate deltas
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // Distance between 2 points
            float hypotenuse = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            // Angle between 2 points
            double angle = Math.Atan2(deltaY, deltaX) * (180 / Math.PI);

            // Print messages
            Console.WriteLine("Distance between points: {0}", hypotenuse);
            Console.WriteLine("Angle between points: {0} degrees", angle);
        }
    }
}
