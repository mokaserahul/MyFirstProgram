using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Assignment
{
    class Assign2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is Even numer");
            }
            else
            {
                Console.WriteLine(a + " is Odd number ");
            }
        }
    }
}
