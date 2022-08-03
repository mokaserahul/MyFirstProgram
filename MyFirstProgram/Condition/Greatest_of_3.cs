using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Condition
{
    class Greatest_of_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Values for A, B and C");
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine(a +" is greater number");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(b +" is greater number");
            }
            else
            {
                Console.WriteLine(c +" is greater number");
            }

        }
    }
}
