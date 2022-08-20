using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
    class Test7
    {
        public static void Maxrow(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i,0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(max<a[i,j])
                    {
                        max = a[i, j];
                    }
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("   Max:" + max);

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = { { 22, 31, 9 }, { 12, 25, 16 } };
            Maxrow(a);
        }
    }
}
