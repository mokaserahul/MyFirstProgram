using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.MyCode
{
    class AreaofRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length and Breadth of Rectangle:");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = l * b;
            Console.WriteLine("Area="+area);
        }
    }
}
