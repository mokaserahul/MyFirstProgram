using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S14_Outer_Elements
    {
        static void Main(string[] args)
        {
            int[,] a = {{1, 2, 3,4},
                        {4, 5, 6,7},
                        {7, 8, 9,1},
                        { 6,4,4,9} };
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i==0)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    else if(i==a.GetLength(0)-1)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else if( j==0)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else if(j==a.GetLength(1)-1)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
