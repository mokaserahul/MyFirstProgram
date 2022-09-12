using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S2_Unique_Pair
    {
        public static void Pair(int[] a,int n)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]+a[j]==n)
                    {
                        Console.WriteLine(a[i]+" "+a[j]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Pair(new int[] { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 }, 7);
        }
    }
}
