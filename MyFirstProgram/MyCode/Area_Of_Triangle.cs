using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.MyCode
{
    class Area_Of_Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base and Height of Triangle:");
            int bs = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double area = 0.5 * bs * h;
            Console.WriteLine("Area:"+area);
        }
    }
}
