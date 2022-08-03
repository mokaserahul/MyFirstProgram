using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Leap_Year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year:");
            int year = int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
