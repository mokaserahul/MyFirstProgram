using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter thee numbers to be compared");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a > b && a > c ? a : b > c ? b : c;
            Console.WriteLine("Largest Number is:"+ max);
        }
    }
}
