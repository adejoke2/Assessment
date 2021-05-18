using System;
using System.Collections.Generic;

namespace Project_fourteen
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> Food = new List<string>();

            Console.Write("Enter first favorite food: ");
            string input1 = Console.ReadLine().Trim();
            Food.Add(FirstInput);

            Console.Write("Enter second favorite food: ");
            string input2 = Console.ReadLine().Trim();
            Food.Add(SecondInput);

            Console.Write("Enter third favorite food: ");
            string input3 = Console.ReadLine().Trim();
            Food.Add(ThirdInput);

            Console.WriteLine($"I love {FirstInput} sooo much.");

            Console.WriteLine($"I love {SecondInput} sooo soo much.");

            Console.WriteLine($"I love {ThirdInput} very so much.");
        }
    }
}
