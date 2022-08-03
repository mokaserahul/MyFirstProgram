using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.IfElseLadder
{
    class N_Greater_Than5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if(n>5)
            {
                Console.WriteLine("The number is greater than 5");
            }
            else
            {
                Console.WriteLine("The number is not greater than 5");
            }
        }
    }
}
