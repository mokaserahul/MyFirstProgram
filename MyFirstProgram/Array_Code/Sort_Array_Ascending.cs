using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Sort_Array_Ascending
    {
        public static void Sort_Asc(int[] a)
        {
            for(int i=0; i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            foreach(int x in a)
            {
                Console.Write(x+" ");
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
            Console.WriteLine("\n.............................");
            Sort_Asc(a);
        }
    }
}
