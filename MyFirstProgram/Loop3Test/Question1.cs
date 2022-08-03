using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mobile Number:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the digit whose Frequency you want:");
            int freq = int.Parse(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                int r = (int)n % 10;
                if (r == freq)
                { 
                    count++;
                }
                n = n / 10;
            }
            Console.WriteLine("Frequency of "+freq+"is:" +count); ;
        }
    }
}
