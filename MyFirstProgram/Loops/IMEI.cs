using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class IMEI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            long n = long.Parse(Console.ReadLine());
            long temp = n;
            long sum = 0;
            while(n>0)
            {
                long r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            if(sum%10==0)
            {
                Console.WriteLine("IMEI Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
