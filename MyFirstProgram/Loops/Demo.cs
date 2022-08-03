using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while(n>0)
            {
                int fact = 1;
                int r = n % 10;
                for(int i=1;i<=r;i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                n = n / 10;
            }
            Console.WriteLine("Sum="+sum);
            if(sum==temp)
            {
                Console.WriteLine("Krishnamurty Number");
            }
            else
            {
                Console.WriteLine("Not a Krishnamurty Number");
            }
        }
    }
}
