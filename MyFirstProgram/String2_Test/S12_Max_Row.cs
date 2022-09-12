using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S12_Max_Row
    {
        public static void MaxRow(int[,] a)
        {
            int max = 0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(max<a[i,j])
                    {
                        max = a[i, j];
                    }
                    Console.Write(a[i,j]+" ");
                }
                Console.Write("   Max:"+max);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = {{1, 2, 3,4},
                        {4, 5, 6,7},
                        {7, 8, 9,1},
                        { 6,4,4,9} };
            MaxRow(a);
        }
    }
}
