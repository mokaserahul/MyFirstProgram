using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Assignment
{
    class Assign6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers to be compared:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a > b && a > c ? a : b > a && b > c ? b : c;
            Console.WriteLine("Max Number:"+ max);
        }
    }
}
