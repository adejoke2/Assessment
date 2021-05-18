using System;
using System.Collections.Generic;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
          List<string> Prime = new List<string>();

          Console.WriteLine("Enter your grade");
          string UserInput = Console.ReadLine();

          string grade = Console.ReadLine();

          if(UserInput == "10")
          {
            Console.WriteLine("Your grade is A");
          }
          else if(UserInput == "20")
          {
            Console.WriteLine("Your grade is B");
          }
          else if(UserInput == "30")
          {
            Console.WriteLine("Your grade is C");   
          }
          else if (UserInput == "40")
          {
            Console.WriteLine("Your grade is D");
          }
          else{
            Console.WriteLine("Your grade is F");
          }
          Prime.Add(UserInput);     
        }
    }
}
