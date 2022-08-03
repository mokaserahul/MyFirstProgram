using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Switch_cases
{
    class Switch_Even_Odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int a = n % 2;
            switch(a)
            {
                case 0: Console.WriteLine("Even Number");
                    break;
                default: Console.WriteLine("Odd Number");
                    break;
            }
        }
    }
}
