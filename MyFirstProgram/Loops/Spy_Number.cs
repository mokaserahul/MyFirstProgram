using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Spy_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int mul = 1;
            while (n > 0)
            {
                int rem = n % 10;
                sum = sum + rem;
                mul = mul * rem;
                n = n / 10;

            }
            if(sum==mul)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not a Spy Number");
            }    
        }
    }
}
