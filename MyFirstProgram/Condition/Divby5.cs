using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Condition
{
    class Divby5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            if(a % 5 == 0)
            {
                Console.WriteLine(a+" is divisible by 5");
            }
            else
            {
                Console.WriteLine(a+" is not divisible by 5");
            }
        }
    }
}
