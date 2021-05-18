using System;
using System.Collections.Generic;

namespace ThirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
          List <int> score = new List<int>();
          int a = 1; int b = 0;

          int c = 0, sum = 0;

          while (a < b)
         {
            Console.WriteLine("Enter score");
                c = sum;
                if (c >= 0)
                {
                    b = c;
                    sum =sum + b;
                    a++;
                }
                else 
                {
                    break;
                }
        }
        double smaller = 0;

        double avg = sum/a;

        for (int i = 0; i < a; i++)
        {
            if (b < avg)
            smaller++;
        }
         Console.WriteLine("The average is: " + avg);

         Console.WriteLine("Scores  above or equal to the average are: " +(a-smaller) );
         
         Console.WriteLine("Scores below average are: " +smaller);
         score.Add(sum);
        }
    }
}
