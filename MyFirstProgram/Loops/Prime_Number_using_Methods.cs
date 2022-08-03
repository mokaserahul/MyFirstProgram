using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Prime_Number_using_Methods
    {
        public int ShowPrime(int n)
        {
            int a = 1;
            for(int i = 2; i < n; i++)
            {
                if(n%i==0)
                {
                    a = 0;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Prime_Number_using_Methods p = new Prime_Number_using_Methods();
            for(int i=0;i<=20;i++)
            {
                if(p.ShowPrime(i)==1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
