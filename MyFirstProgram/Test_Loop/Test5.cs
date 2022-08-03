using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test5
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int k=1;k<=i;k++)
                {
                    Console.Write(" ");
                }
                for(int j=5;j>=i;j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
