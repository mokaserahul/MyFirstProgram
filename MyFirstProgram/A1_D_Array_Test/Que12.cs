using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que12
    {
            
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==0)
                {
                    a[i] = 1;
                }
                Console.Write(a[i]+" ");
            }
        }
    }
}
