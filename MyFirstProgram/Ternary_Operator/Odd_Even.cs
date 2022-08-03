using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Ternary_Operator
{
    class Odd_Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            string res = n % 2 == 0 ? "Even Number" : "Odd Number";
            Console.WriteLine(res);
        }
    }
}
