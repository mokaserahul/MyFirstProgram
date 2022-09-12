using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S10_Matrix
    {
        static void Main(string[] args)
        {
            int[,] a= new int[3, 4];
            Console.WriteLine("Enter Array Elements");
            for(int i =0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
