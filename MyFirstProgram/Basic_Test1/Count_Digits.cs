using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Count_Digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                int r = n % 10;
                n = n / 10;
                count++;
            }
            Console.WriteLine("Number of digits=" + count);
        }
    }
}
