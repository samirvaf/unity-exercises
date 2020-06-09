using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            String menu = "*****\n1 - New Game\n2 - Load Game\n3 - Options\n4 - Quit\n*****";
            Console.WriteLine(menu + "\nSelect a option from the menu");
            int option = int.Parse(Console.ReadLine());

            while (option != 4)
            {
                switch (option) {
                    case 1:
                        Console.WriteLine("Creating new game ...\n");
                        break;
                    case 2:
                        Console.WriteLine("Loading game ...\n");
                        break;
                    case 3:
                        Console.WriteLine("Opening options ...\n");
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again\n");
                        break;
                }
                Console.WriteLine(menu + "\nSelect a option from the menu");
                option = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ending game ...");
        }
    }
}
