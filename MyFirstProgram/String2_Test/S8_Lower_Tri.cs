using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S8_Lower_Tri
    {

        public static int[,] Lower_Tri(int[,] a)
        { 
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (i < j)
                    {
                        a[i, j] = 0;
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[,] matrix = {{1, 2, 3,4},
                        {4, 5, 6,7},
                        {7, 8, 9,1},
                        { 3,4,4,2} };
            int[,] res=Lower_Tri(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
              {
                  for (int j = 0; j < res.GetLength(1); j++)
                  {
                      Console.Write(res[i, j] + " ");
                  }
                  Console.WriteLine();
              }
        }
    }
}
