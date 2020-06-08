using System;
using System.Collections.Generic;
using ConsoleCards;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receive 2 numbers and print from the lowest to the highest
            Console.Write("Type a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Type another number: ");
            int num2 = int.Parse(Console.ReadLine());

            int bigger = num1;
            int lower = num2;
            if (num2 > num1)
            {
                bigger = num2;
                lower = num1;
            }

            for (int i = lower; lower <= bigger; lower++)
            {
                Console.WriteLine(lower);
            }

            // Instantiate deck class
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // Shuffle deck and deal 5 cards
            deck.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            // Flips all cards in hand
            for (int i = 0; i < hand.Count; i++)
            {
                hand[i].FlipOver();
            }

            // Prints cards in hand
            foreach (Card card in hand)
            {
                card.Print();
            }
        }
    }
}
