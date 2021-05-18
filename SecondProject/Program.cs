using System;
using System.Collections.Generic;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Reverse = new List<int>();
            Console.WriteLine("Enter an integer you wanna reverse");
            int UserInput = Convert.ToInt32(Console.ReadLine());
 
            int[] values;
        
            values = new int[10];
          
           Console.WriteLine("Please enter ten numbers."); 

           for (int i = 0; i < 10; i++)
           {
             values[i] = UserInput. 
              Console.WriteLine("Number in reverse:"); 
           }            
          // for (int i =9; i >=0 ; i--)
          // {
          //   Console.WriteLine(values[i]); 
          // }
          Reverse.Add(UserInput);
        }
    }
}
