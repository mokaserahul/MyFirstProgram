using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Odd_Elements
    {
        public int OddCount(int[] a)
        {
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Array elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Odd_Elements o = new Odd_Elements();
            int count = o.OddCount(a);
            Console.WriteLine("Count:"+count);
        }
    }
}
