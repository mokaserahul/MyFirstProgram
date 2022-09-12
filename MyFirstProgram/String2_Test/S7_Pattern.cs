using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S7_Pattern
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                if (i % 2 == 0)
                {
                    int c = 1;
                    for (char j = 'A'; c <= i; j++)
                    {
                        Console.Write(j);
                        c++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            for(int i=2;i<=5;i++)
            {
                if (i % 2 == 0)
                {
                    int c = 1;
                    for (char j = 'A'; c <= i; j++)
                    {
                        Console.Write(j);
                        c++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
