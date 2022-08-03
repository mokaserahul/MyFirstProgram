using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Sum_of_First_and_Last_Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int last = n % 10;
            while(n>=10)
            { 
                n = n / 10;
            }
            int first = n;
            sum = first + last;
            Console.WriteLine("Sum="+sum);
        }
    }
}
