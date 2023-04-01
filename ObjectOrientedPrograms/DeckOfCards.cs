using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class DeckOfCards
    {
        private static readonly string[] SUITS = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private static readonly string[] RANKS = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        private static readonly int NUM_CARDS = SUITS.Length * RANKS.Length;
        string[] deck = new string[NUM_CARDS];
        string[,] players = new string[4, 9];


        // Initialize deck of cards
        public void Card()
        {
            for (int i = 0; i < RANKS.Length; i++)
            {
                for (int j = 0; j < SUITS.Length; j++)
                {
                    deck[SUITS.Length * i + j] = RANKS[i] + " of " + SUITS[j];
                }
            }
        }

        // Shuffle the deck using Random method
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = NUM_CARDS - 1; i > 0; i--)
            {
                int index = rnd.Next(i + 1);
                string temp = deck[index];
                deck[index] = deck[i];
                deck[i] = temp;
            }
        }

        // Distribute 9 cards to 4 players
        public void Distribute()
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    players[i, j] = deck[i * 9 + j];
                }
            }
        }

        // Print the cards received by each player using a 2D array
        public void Display()
        { 
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\nPlayer " + (i + 1) + " cards:");
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(players[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
