using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.NestedIfElse
{
    class GreatestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three Values for A B and C");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("A is greater");
                }
                else
                {
                    Console.WriteLine("C is greater");
                }
            }
            else if(b>a)
            {
                if(b>c)
                {
                    Console.WriteLine("B is greater");
                }
                else
                {
                    Console.WriteLine("C is greater");
                }
            }
            else
            {
                Console.WriteLine("C is greater");

            }
        }
    }
}
