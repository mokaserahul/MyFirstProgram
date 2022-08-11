using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Min_Char
    {
        public static char Minchar(char[] a)
        {
            char min = a[0];
            foreach(int x in a)
            {
                Console.WriteLine((char)(x)+" "+x);
            }
            for(int i=0;i<a.Length;i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Elements:");
            char[] c = new char[5];
            for(int i=0;i<c.Length;i++)
            {
                c[i] = char.Parse(Console.ReadLine());
            }
            char min = Minchar(c);
            Console.WriteLine("Min Char:"+min);
        }
    }
}
