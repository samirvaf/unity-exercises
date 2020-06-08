using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of ints
            List<int> lista = new List<int>();

            // Populate the list with numbers from 1 to 10
            for(int i = 1; i <= 10; i++)
            {
                lista.Add(i);
            }

            // Print list elements
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            // Remove even numbers from the list
            for(int i = lista.Count - 1; i >= 0; i--)
            {
                if(lista[i] % 2 == 0)
                {
                    lista.Remove(lista[i]);
                }
            }

            // Print list elements
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
