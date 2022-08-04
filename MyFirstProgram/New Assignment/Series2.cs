using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Assignment
{
    class Series2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int series = 2;
            Console.Write(series+" ");
            for(int i=1;i<=n;i++)
            {
                series = series * 2 - 1;
                Console.Write(series+" ");
            }
        }
    }
}
