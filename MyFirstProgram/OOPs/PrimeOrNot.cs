using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class PrimeOrNot
    {
        bool Prime(int n)
        {
            bool isprime = true;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    isprime = false;
                }
            }
            return isprime;
        }
        static void Main(string[] args)
        {
            PrimeOrNot p = new PrimeOrNot();
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if(p.Prime(n)==true)
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
