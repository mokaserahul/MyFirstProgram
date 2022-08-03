using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class StaticDemo
    {
        static public void Area(int l, int b)
        {
            Console.WriteLine("Area of Rectangle:" + l * b);
        }
        static public void Area(int s)
        {
            Console.WriteLine("Area of Square:" + s * s);
        }
        static public void Area(float r)
        {
            Console.WriteLine("Area of Circle:" + 3.14 * r * r);
        }
        static public void Area(float b, int h)
        {
            Console.WriteLine("Area of Triangle:" + 0.5 * b * h);
        }
        static void Main(string[] args)
        {
            Area(13);
            Area(12, 14);
            Area(5.0f);
            Area(3.0f, 23);
        }
    }
}
