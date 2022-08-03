using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question4
    {
        
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int j = i; j>=1 ;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n************************\n************************");
            
            for(int i=1;i<=5;i++)
            {
                for(int k=5;k>=i;k--)
                {
                    Console.Write(" ");
                }
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(0);
                            
                        }
                        else
                        {
                            Console.Write(1);
                        }
                    }
                }
                else
                {
                    for(int j=1;j<=i; j++)
                    {
                        if(j%2==0)
                        {
                            Console.Write(0);
                        }
                        else
                        {
                            Console.Write(1);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
