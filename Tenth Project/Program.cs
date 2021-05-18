﻿using System;

namespace Tenth_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter Integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            int smallestNumber = 0;
            int biggestNumber = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            int smallest = Numbers[0];
            int biggest = Numbers[0];

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] <= smallest)
                {
                    smallestNumber = Numbers[i];
                }

                if(Numbers[i] >= biggest)
                {
                    biggestNumber = Numbers[i];
                }
            }
            Console.WriteLine($"The multiplication of the smallest number and the biggest number is {smallestNumber*biggestNumber}");
         
        }
    }
}
