using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Assignment
{
    class Assign1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if(n>5)
            {
                Console.WriteLine("Greater than 5");
            }
            else
            {
                Console.WriteLine("Less than 5");
            }
        }
    }
}
