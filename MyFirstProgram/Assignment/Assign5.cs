using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Assignment
{
    class Assign5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if(n>=0 && n<=9)
            {
                Console.WriteLine("Single Digit");
            }
            else if(n>=10 && n<=99)
            {
                Console.WriteLine("Double Digit");
            }
            else
            {
                Console.WriteLine("Different character");
            }
        }
    }
}
