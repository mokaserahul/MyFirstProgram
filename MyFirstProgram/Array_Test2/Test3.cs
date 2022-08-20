using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Test2
{
    class Test3
    {
        public static void CheckCount(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int j=i-1;j>=0;j--)
                {
                    if(a[j]==a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[j]==a[i])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+":"+count);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n......................................");
            CheckCount(a);
        }

    }
}
