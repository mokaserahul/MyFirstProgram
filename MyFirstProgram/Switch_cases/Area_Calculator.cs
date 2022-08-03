using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Switch_cases
{
    class Area_Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice(1-4) from the menu");
            Console.WriteLine("1.Area of Rectangle\n2.Area of Circle\n3.Area of Triangle\n4.Area of Square");
            int ch = int.Parse(Console.ReadLine());
            double area;
            switch(ch)
            {
                case 1:Console.WriteLine("Enter Length and Breadth of Rectangle:");
                    int l = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("Area="+area);
                    break;
                case 2: Console.WriteLine("Enter the Radius of Circle:");
                    int r = int.Parse(Console.ReadLine());
                    area = 3.14 * r * r;
                    Console.WriteLine("Area="+area);
                    break;
                case 3: Console.WriteLine("Enter the Base and Height of Triangle:");
                    int bs = int.Parse(Console.ReadLine());
                    int h = int.Parse(Console.ReadLine());
                    area = 0.5 * bs * h;
                    Console.WriteLine("Area=" + area);
                    break;
                case 4: Console.WriteLine("Enter the Side of the Square:");
                    int side = int.Parse(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("Area=" + area);
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
