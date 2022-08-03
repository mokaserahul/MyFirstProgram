using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Divisible_By_5_and_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            if(n%5==0 || n%11==0)
            {
                if (n % 5 == 0)
                {
                    Console.WriteLine("The Number is divisible by 5");
                }
                else
                {
                    Console.WriteLine("The Number is divisible by 11");
                }
            }
            else
            {
                Console.WriteLine("The Number is neither divisible by 5 nor by 11");
            }
        }
    }
}
