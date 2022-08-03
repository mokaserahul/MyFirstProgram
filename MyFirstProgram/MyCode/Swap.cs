using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.MyCode
{
    class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value for A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value for B");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping A is " + a + " and B is " + b);
        }
    }
}
