using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Area_Of_Eq_Triangle
    {
        static void Main(string[] args)
        {
            int a;
            double area;
            Console.WriteLine("Enter the side length of the Trangle:");
            a = int.Parse(Console.ReadLine());
            area = (1.73 * a * a) / 4;
            Console.WriteLine("Area of the Triangle is:"+ area);
        }
    }
}
