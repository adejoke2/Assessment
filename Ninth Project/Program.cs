using System;
using System.Collections.Generic;

namespace Ninth_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> DeckOfCards = new List<string> { "Ace", "Queen", "King", "Jack" };

            int Add = 0;

            for (int i = 1; i < 5; i++)
            {
                Random random = new Random();
                int index = random.Next(0, 3);

                Console.Write("Press any key to pick a card");
                Console.ReadKey();

                if (DeckOfCards[index] == "Ace")
                {
                    Console.WriteLine($"{i}. The card you picked is {DeckOfCards[index]} and its number is 1. ");
                    Add++;
                }

                else if (DeckOfCards[index] == "King")
                {
                    Console.WriteLine($"{i}. The card you picked is {DeckOfCards[index]} and its number is 13. ");
                    Add += 13;
                }

                else if (DeckOfCards[index] == "Queen")
                {
                    Console.WriteLine($"{i}. The card you picked is {DeckOfCards[index]} and its number is 12. ");
                    Add += 12;
                }

                else if (DeckOfCards[index] == "Jack")
                {
                    Console.WriteLine($"{i}. The card you picked is {DeckOfCards[index]} and its number is 11. ");
                    Add += 11;
                }
            }
            Console.WriteLine($"The overall addition of the cards is: {Add}");

		}
    }
}
