using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Assignment
{
    class Merge_Array
    {
        public static void Merge(int[] a,int[] b,int[] c)
        {
            int m = 0;
            for(int i=0;i<a.Length;i++)
            {
                bool ispresent = false;
                for(int j=m-1;j>=0;j--)
                {
                    if(c[j]==a[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if(ispresent==false)
                {
                    c[m] = a[i];
                    m++;
                }    
            }
            for(int i=0; i<b.Length;i++)
            {
                bool ispresent = false;
                for(int j=m-1;j<=0;j--)
                {
                    if(c[j]==b[i])
                    {
                        ispresent = true;
                        break;
                    }

                }
                if(ispresent==false)
                {
                    c[m] = b[i];
                    m++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[a.Length + b.Length];
            Console.WriteLine("Enter the Elements of First Array:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Elements of Second Array:");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Merge(a, b, c);
            foreach(int x in c)
            {
                Console.Write(x+" ");
            }
        }
    }
}
