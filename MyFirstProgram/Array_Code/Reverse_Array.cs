using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Reverse_Array
    {
        static void Main(string[] args)
        {
            char[] a = new char[5];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));

            Console.WriteLine("...........Reverse String...........");
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
