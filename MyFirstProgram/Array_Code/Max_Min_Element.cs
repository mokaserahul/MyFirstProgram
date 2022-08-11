using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Max_Min_Element
    {
        public static int Max(int[] a)
        {
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static int Min(int[] b)
        {
            int min = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if(min>b[i])
                {
                    min = b[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] n = new int[5];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0; i<n.Length;i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            int max = Max(n);
            Console.WriteLine("Max:"+max);
            int min = Min(n);
            Console.WriteLine("Min:"+min);
        }

    }
}
