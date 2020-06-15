using System;

namespace Exercise9
{
    public class Apple
    {
        float amountLeft;
        bool organic;

        public Apple(bool organic, float size)
        {
            amountLeft = size;
            this.organic = organic;
        }

        public float AmountLeft { get { return amountLeft; } }
        public bool Organic { get { return organic;  } }

        public void TakeBite(float size)
        {
            if (organic)
            {
                amountLeft -= size;
                Console.WriteLine($"Amount left: {amountLeft}");
            }
            else
            {
                Console.WriteLine("This apple is not organic!");
            }
        }
    }
}
