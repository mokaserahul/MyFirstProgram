using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Condition
{
    class Multiple_of_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            if(n % 5 == 0)
            {
                Console.WriteLine("The number is a multiple of 5");
            }
            else
            {
                Console.WriteLine("Not a multiple of 5");
            }

        }
    }
}
