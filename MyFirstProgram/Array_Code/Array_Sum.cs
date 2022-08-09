using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Array_Sum
    {
        public int ArraySum(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Array_Sum s = new Array_Sum();
            int sum = s.ArraySum(a);
            Console.WriteLine("Sum:"+sum);
        }
    }
}
