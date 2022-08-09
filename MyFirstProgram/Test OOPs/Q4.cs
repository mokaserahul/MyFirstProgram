using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_OOPs
{
    class Q4
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= a; j++)
                {
                    Console.Write(j);
                }
                a = a + 2;
                Console.WriteLine();
            }
        }
    }
}
