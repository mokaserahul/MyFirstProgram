using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Ternary_Operator
{
    class Greater_Num_Ternary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three numbers A, B and C:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string res = a > b && a > c ? "A is greater":b > a && b > c ? "B is greater" : "C is greater";
            Console.WriteLine(res);
        }
    }
}
