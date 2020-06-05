using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleCards;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 Solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practice using lists
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create deck and hand
            Deck deck = new Deck();
            List<Card> cards = new List<Card>();

            deck.Shuffle();

            // add card, flip over, and print
            cards.Add(deck.TakeTopCard());
            cards[0].FlipOver();
            cards[0].Print();
            Console.WriteLine();

            // add another card, flip over, and print both cards
            cards.Add(deck.TakeTopCard());
            cards[1].FlipOver();
            cards[1].Print();
            cards[0].Print();

            Console.WriteLine();
        }
    }
}

