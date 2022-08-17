using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Assignment
{
    class Replace_Elements
    {
        public static void Replace(int[] a)
        {
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n...........................");
            for (int i=0;i<a.Length;i++)
            {
                if(a[i]<0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }

        }
        static void Main(string[] args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Replace(a);
        }
    }
}
