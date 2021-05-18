using System;
using System.Collections.Generic;

namespace Project_Seventeen
{
    class Program
    {
        static void Main(string[] args)
        {
          List<int> Numbers = new List<int>();
        
        
            Console.Write("Enter Integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            int[] occurence = new int[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < Numbers.Count; i++)
                {
                    if(Numbers[j] == i)
                    {
                        occurence[i]++;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} occur {occurence[i]} times. ");
            }
            if (occurance == 1) 
            {
            Console.WriteLine(" time.");
            }
            else
            {
                Console.WriteLine(" times.");
            }
                
              
        }                       
    }
}
