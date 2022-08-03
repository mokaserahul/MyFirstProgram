using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops_Test2
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Factors of "+n+" are:");
            for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    Console.Write(" "+i);
                }
            }
        }
    }
}
