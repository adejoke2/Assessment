using System;

namespace Project_sixteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some integers between 1 and 100 (and 0 when done): ");
             int Input = Convert.ToInt32(Console.ReadLine());

            int[] myArray = new int[1000];

            int number;
            int count = 0;

            do
            {
                number = int.();
                myArray[count] = number;
                count++;
            }

            while (number != 0);
            
              int[] mySort = new int [count - 1];  
             

            for(int i = 0; i< (count-1); i++) 
            { 
              mySort[i] = myArray[i];
            }

            Array.Sort(mySort);

            int n = 0;

            for(int i = 0; i < mySort.Length; i++)
            {
                 int occurance = 0;
                if(n >= mySort[i]) 
                {
                    continue;
                }
                else
                {
                    n = mySort[i];
                } 
                for (int j=0; j<mySort.Length; j++)
                {
                    if (n == mySort[j])
                    {
                        occurance++; 
                        Console.WriteLine(n +  " occurs " + occurance );
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
        
    }
}
