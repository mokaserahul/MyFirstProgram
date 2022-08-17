using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_2D
{
    class Lower_Triangle
    {
        public static void Pattern_Tri(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i>=j)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        
                        a[i, j] = 0;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Console.WriteLine("Enter the Elements:");
           
            Pattern_Tri(a);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
