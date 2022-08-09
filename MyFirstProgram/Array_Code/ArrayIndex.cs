using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class ArrayIndex
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter Array elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                if(i%2==0)
                {
                    Console.Write(a[i]+" ");
                }
            }
        }
    }
}
