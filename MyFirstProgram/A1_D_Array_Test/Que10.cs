using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que10
    {
        public static void PerfectSquare(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\n.....................");
            for (int i = 0; i < a.Length; i++)
            {
                for(int j=1;j<a[i];j++)
                {
                    if (j * j == a[i])
                    {
                        Console.Write(a[i]+" ");
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter array elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            PerfectSquare(a);
        }
    }
}
