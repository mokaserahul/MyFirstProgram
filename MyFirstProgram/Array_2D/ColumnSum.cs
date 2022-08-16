using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_2D
{
    class ColumnSum
    {
        public static void Columnsum(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("  Sum:" + sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the Elements of Matrix:");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Columnsum(a);
        }
    }
}
