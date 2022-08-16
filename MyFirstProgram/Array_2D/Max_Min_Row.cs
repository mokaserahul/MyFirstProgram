using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_2D
{
    class Max_Min_Row
    {
        public static void MaxMin(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int max = a[i, 0];
                int min = a[i, 0];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if(max<a[i,j])
                    {
                        max = a[i, j];
                    }
                    else if(min>a[i,j])
                    {
                        min = a[i, j];
                    }
                    Console.Write(a[i,j]+" ");
                }
                Console.Write("  Max:"+max+" Min:"+min);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the Elements of Matrix:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            MaxMin(a);
        }
    }
}    

