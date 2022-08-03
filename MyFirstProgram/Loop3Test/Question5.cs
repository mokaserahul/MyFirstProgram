using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int c = 3;
            //  Console.Write(0);
            Console.Write(a);
            for (int i = 1; i < n; i++)
            {
                a = a+c;
                Console.Write(" " + a);
                c = c + 2;
                
            }
        }
    }
}
