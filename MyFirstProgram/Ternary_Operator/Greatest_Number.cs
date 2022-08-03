using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Ternary_Operator
{
    class Greatest_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers A, B and C:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string res = a > b ? a > c ? "A is greater" : "C is greater" : b > c ? "B is greater" : "C is greater";
            Console.WriteLine(res);
        }
    }
}
