using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two prime numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 2; i < a; i++) 
            {
                for(int j=2;j<b;j++)
                {
                    if (a % i == 0 || b % j == 0)
                    {
                        check = 1;
                    }
                }
            
            }
            if(check==0)
            {
                if (a - b == 2 || b - a == 2)
                {
                    Console.WriteLine("Twin Prime");
                }
                else
                {
                    Console.WriteLine("Not Twin Prime");
                }
            }
            else
            {
                Console.WriteLine("Both numbers should be a Prime number");
            }
        }
    }
}
