using System;

namespace Exercise15
{
    /// <summary>
    /// Practice if and switch statements
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********\nGame Menu:\n1 - New Game\n2 - Load Game\n3 - Options\n4 - Quit\n**********");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Creating game ...");
                    break;
                case 2:
                    Console.WriteLine("Loading game ...");
                    break;
                case 3:
                    Console.WriteLine("Opening game options ...");
                    break;
                case 4:
                    Console.WriteLine("Quitting game ...");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            if (option == 1)
            {
                Console.WriteLine("Creating game ...");
            }
            else if (option == 2)
            {
                Console.WriteLine("Loading game ...");
            }
            else if (option == 3)
            {
                Console.WriteLine("Opening game options ...");
            }
            else if (option == 4)
            {
                Console.WriteLine("Quitting game ...");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
