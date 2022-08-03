using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Table_of_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int mul = 1;
            for(int i=1;i<=10;i++)
            {
                 mul = i * n;
                 Console.WriteLine(n+"x"+i+"="+mul);
            }
        }
    }
}
