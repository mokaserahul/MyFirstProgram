using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for(int i=1;i<=n;i++)
            {
                fact = fact*i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
