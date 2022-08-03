using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Sum_of_Even_Digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n>0)
            {
                int r = n % 10;
                if (r % 2 == 0)
                {
                    sum = sum + r;
                }
                n = n / 10;
            }
            Console.WriteLine("Sum="+sum);
        }
    }
}
