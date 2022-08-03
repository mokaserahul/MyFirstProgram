using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Area_Calculate
    {
        public void Area(int l,int b)
        {
            Console.WriteLine("Area of Rectangle:"+l*b);
        }
        public void Area(int s)
        {
            Console.WriteLine("Area of Square:"+s*s);
        }
        public void Area(float r)
        {
            Console.WriteLine("Area of Circle:" + 3.14 * r * r);
        }
        public void Area(float b, int h)
        {
            Console.WriteLine("Area of Triangle:" + 0.5 * b * h);
        }
        static void Main(string[] args)
        {
            Area_Calculate a = new Area_Calculate();
            a.Area(13);
            a.Area(12, 14);
            a.Area(5.0f);
            a.Area(3.0f, 23);
        }
    }
}
