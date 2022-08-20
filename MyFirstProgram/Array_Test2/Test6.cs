using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
    class Test6
    {
        public static void ArrayReverse(int[,] arrcopy)
        {
            
            for (int i=0;i<arrcopy.GetLength(0);i++)
            {
                int m = 0;
                int n = arrcopy.GetLength(1) - 1;
                while (m<n)
                {
                    int temp = arrcopy[i, m];
                    arrcopy[i, m] = arrcopy[i,n];
                    arrcopy[i, n] = temp;
                    m++;
                    n--;
                }
            }
            for (int i = 0; i < arrcopy.GetLength(0); i++)
            {
                for (int j = 0; j < arrcopy.GetLength(1); j++)
                {
                    Console.Write(arrcopy[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n...........................");
            ArrayReverse(arr);
        }
    }
}
