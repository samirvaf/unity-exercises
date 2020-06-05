using System;

namespace Exercise6
{
    /// <summary>
    /// Trigonometry with Floats
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me an angle: ");
            float angle = float.Parse(Console.ReadLine());
            float cos = (float)Math.Cos(angle * (float)Math.PI / 180);
            float sin = (float)Math.Sin(angle * (float)Math.PI / 180);
            Console.WriteLine($"For the angle {angle} degrees. Cos = {cos} Sin = {sin}");
        }
    }
}
