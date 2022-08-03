using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Automorphic_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int sq = num * num;
            int a = 0;
            while(num>0)
            {
                if (num % 10 != sq % 10)
                {
                    a = 1;
                }
                num = num / 10;
                sq = sq / 10;
            }
            if (a == 0)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not an Automorphic Number");
            }
        }
    }
}
