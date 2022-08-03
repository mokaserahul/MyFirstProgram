using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.MyCode
{
    class Swap_WO_Third_Variable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Values for A and B");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("A="+a +"  B="+ b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping A="+a +"  B="+ b);
        }
    }
}
