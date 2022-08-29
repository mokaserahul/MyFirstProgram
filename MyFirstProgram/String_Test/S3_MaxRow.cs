using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S3_MaxRow
    {
        public static void MaxRow(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
                Console.Write(" Max: " + max + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr={ { 22, 31, 9 }, { 12, 25, 16 } };
            MaxRow(arr);
        }
    }
}
