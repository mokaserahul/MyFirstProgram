using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test4
    {
        static void Main(string[] args)
        {
            int x = 1;
            for(int i=1;i<=6;i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=x;j++)
                {
                   
                    Console.Write(i+" ");

                }
                x = x + 2;
                /*for(int l=i-1;l>=1;l--)
                {
                    int n = 1;
                    Console.Write(l+n);
                    n=n+2;
                }*/
                Console.WriteLine();
            }
        }
    }
}
