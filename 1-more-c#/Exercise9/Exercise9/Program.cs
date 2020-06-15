using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple good = new Apple(true, 10);

            Console.WriteLine(good.AmountLeft);
            Console.WriteLine(good.Organic);
        }
    }
}
