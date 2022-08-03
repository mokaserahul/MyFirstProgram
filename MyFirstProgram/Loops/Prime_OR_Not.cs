using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Prime_OR_Not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for(int i=2;i<n;i++)
            {
                if(n % i == 0)
                {
                    a = 1;
                }
            
            }
            if(a==0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
