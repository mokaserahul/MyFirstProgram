using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S4_Reverse_Preserve_Spaces
    {
        public static string Reverse(string s)
        {
            char[] c = s.ToCharArray();
            char[] result = new char[c.Length];
            for(int i=0;i<c.Length;i++)
            {
                if(c[i]==' ')
                {
                    result[i] = ' ';
                }
            }
            int j = c.Length - 1;
            for(int i=0;i<c.Length;i++)
            {
                if (c[i] != ' ')
                {
                    if (result[j] == ' ')
                    {
                        j--;
                    }
                    result[j] = c[i];
                    j--;
                }
            }
            string a = string.Join("", result);
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            string res=Reverse(s);
            Console.WriteLine(res);
        }
    }
}
