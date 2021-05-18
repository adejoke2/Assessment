using System;

namespace Fifth_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Number = new List<int>();

            Console.Write("Enter Integers with seprated space: ");
            string input = Console.ReadLine();

            string[] UserInput = input.Split(" ");

            int biggestNumber = 0;

            int smallestNumber = 0;

            for (int i = 0; i < UserInput.Length; i++)
            {
                int number = Convert.ToInt32(UserInput[i]);

                Number.Add(number);
            }

            int small = Number[0];

            int biggest = Number[0];

            for (int i = 0; i < Number.Count; i++)
            {
                if(Number[i] <= small)
                {
                    smallestNumber = Number[i];
                }

                if(Number[i] >= biggest) 
                {
                    biggestNumber = Number[i];
                }
            }

            for (int i = smallestNumber; i <= biggestNumber; i++)
            {
                Console.WriteLine(i);
            }
            
                

        }        
    }
}
