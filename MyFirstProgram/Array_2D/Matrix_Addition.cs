using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_2D
{
    class Matrix_Addition
    {
        public static void Addmatrix(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(".................");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(".................");


            int[,] c = new int[3, 3];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
        public static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            Console.WriteLine("Enter Elements for first Matrix:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Elements for second Matrix:");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Addmatrix(a, b);
        }
    }
}
