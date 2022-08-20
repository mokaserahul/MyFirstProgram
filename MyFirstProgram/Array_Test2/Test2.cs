using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
    class Test2
    {
        public static void SwapLast(int[] a)
        {
            int temp1 = a[a.Length - 1];
            int temp2 = a[a.Length - 2];
            a[a.Length - 1] = a[0];
            a[a.Length - 2] = a[1];
            a[0] = temp1;
            a[1] = temp2;

            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n.............................................");
            SwapLast(a);
        }
    }
}
