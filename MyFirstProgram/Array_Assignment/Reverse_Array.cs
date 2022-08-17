using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Assignment
{
    class Reverse_Array
    {
        public static void Rev(int[] a)
        {
            int j = a.Length-1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n..............................");
            Rev(a);
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
        }
    }
}
