using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_2D
{
    class Check_Sparse
    {
        public static bool Sparse_Check(int[,] a)
        {
            
            int zero = 0, nonzero = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 0)
                    {
                        zero++;
                    }
                    else
                    {
                        nonzero++;
                    }
                }

            }
            if(zero>nonzero)
            {
                return true; ;
            }
            else
            {
                return false;
            }
           /* if(zero>nonzero)
            {
                Console.WriteLine("Sparse Matrix");
            }
            else
            {
                Console.WriteLine("Not a Sparse Matrix");
            }*/
        }
        static void Main(string[] args)
        {

            int[,] a = new int[4, 4];
            Console.WriteLine("Enter the Elements:");
            for (int i = 0; i < a.GetLength(0); i++)
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
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            if(Sparse_Check(a)==true)
            {
                Console.WriteLine("Sparse Matrix");
            }
            else
            {
                Console.WriteLine("Not a Sparse Matrix");

            }
        }
    }
}
