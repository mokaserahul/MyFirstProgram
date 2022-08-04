using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Assignment
{
    class Perimeter_of_Rectangle
    {
        static int Perimeter(int l, int b)
        {
            int p = 2 * (l + b);
            return p;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Rectangle:");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter of Rectangle:"+Perimeter(l,b));
        }
    }
}
