using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Assignment
{
    class Prime_Check
    {
        static bool isprime(int n)
        {
            
            int count = 0;
            for (int i =1;i<=n;i++)
            {

                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                if (isprime(n) == true)
                {
                     Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
                Console.WriteLine("Enter a Number:");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
