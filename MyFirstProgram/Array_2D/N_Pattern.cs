using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_2D
{
    class N_Pattern
    {
        public static void Pattern(int[,] a)
        {
            Console.WriteLine("........................");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if ( j == 0 || i == j ||j==a.GetLength(1)-1)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Enter the Elements:");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Pattern(a);

        }
    }
}
