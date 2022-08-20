using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
   
    class Test1
    {
        public static void MergeArray(int[] a, int[] b, int[] c)
        {
            int i = 0,j=0,k=0;
            while (i < a.Length && j<b.Length)
            {
                c[k++] = a[i++];
                c[k++] = b[j++];
            }
            while (i < a.Length)
            {
                c[k++] = a[i++];
            }
            while (j < b.Length)
            {
                c[k++] = b[j++];
            }
            foreach (int x in c)
            {
                Console.Write(x+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] b = { 11, 22, 33, 44 };
            int[] c = new int[a.Length + b.Length];
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            foreach (int x in b)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n.....................................");
            MergeArray(a, b, c);
        }
    }
}
