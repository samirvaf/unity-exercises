using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Hello! This is 'Nothing Like Blackjack', hope you like it!\n");
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine("Shuffle deck!\n");

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card p1Card1 = deck.TakeTopCard();
            Card p2Card1 = deck.TakeTopCard();
            Card p3Card1 = deck.TakeTopCard();
            Card p1Card2 = deck.TakeTopCard();
            Card p2Card2 = deck.TakeTopCard();
            Card p3Card2 = deck.TakeTopCard();
            Card[] allGivenCards = { p1Card1, p2Card1, p3Card1, p1Card2, p2Card2, p3Card2 };

            // flip all the cards over
            foreach (Card card in allGivenCards)
            {
                card.FlipOver();
                Console.WriteLine($"Flipping over {card.Rank} of {card.Suit}");
            }
            Console.WriteLine();

            // print the cards for player 1
            Console.WriteLine($"Player 1 cards: {p1Card1.Rank} of {p1Card1.Suit} and {p1Card2.Rank} of {p1Card2.Suit} \n");

            // print the cards for player 2
            Console.WriteLine($"Player 2 cards: {p2Card1.Rank} of {p2Card1.Suit} and {p2Card2.Rank} of {p2Card2.Suit} \n");

            // print the cards for player 3
            Console.WriteLine($"Player 3 cards: {p3Card1.Rank} of {p3Card1.Suit} and {p3Card2.Rank} of {p3Card2.Suit} \n");
        }
    }
}
