using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
    class Test4
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Rearrange(int[] a)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            while(i<a.Length)
            {
                if (a[c] < 0)
                {
                    Swap(ref a[c], ref a[i]);
                    c++;
                    i++;
                }
                
            }     
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2,3, -4, -1, 4 };
           /* int[] a = new int[10];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }*/
            foreach (int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n..................................");
            Rearrange(a);
        }
    }
}
