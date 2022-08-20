using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
    class Test5
    {
        public static void SeperateZero(int[] a)
        {
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] != 0)
                {
                    a[j] = a[i];
                    j++;
                }
            }
            while (j < a.Length)
            {
                a[j] = 0;
                j++;
            }
            foreach (int x in a)
            {
                Console.Write(x+" ");
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
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n..................................");
            SeperateZero(a);
        }
    }
}
