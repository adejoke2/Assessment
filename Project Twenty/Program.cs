using System;

namespace Project_Twenty
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] arr = { 1, 2, 3, 4, 5, 6 };
          int even = 0, odd = 0;
 
          for (int i = 0; i < arr.Length; i++)
          {
            if (i % 2 == 0)
            {
                even += arr[i];
            }
                
            else
            {
              odd += arr[i];
            }        
          }
 
          Console.WriteLine("Even index positions" + " sum: " + even);
                            
                              
           Console.WriteLine("Odd index positions " + "sum: " + odd);
                              
        }
    }
}
