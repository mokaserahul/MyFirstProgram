using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.MyCode
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("LP");
            }
            else
            {
                Console.WriteLine("Non LP");
            }
        }
    }
}
